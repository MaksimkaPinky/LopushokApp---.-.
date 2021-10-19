using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LopushokApp.ModelEF;

namespace LopushokApp
{
    public partial class Form1 : Form
    {
        /////////////////////////////////////////////////
        // 4-LopushokApp (UserControls + страницы)
        // (самая полная версия)
        /////////////////////////////////////////////////
        // Константы программы
        // количество товаров на странице (форме)
        static int nProdList = 20;
        // количество кнопок
        static int numButtons = 5;   

        // коллекция ID выбранных товаров
        static public List<int> lstSelectedProduct = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        // коллекция показываемых товаров
        List<Product> lstProduct = new List<Product>();

        // коллекция пользов. элементов управления для показа
        List<ProductUserCntrl> lstControls = new List<ProductUserCntrl>();
        Button[] btnsList = new Button[5];
        private void Form1_Load(object sender, EventArgs e)
        {
            // устанавливаем тип сортировки
            SortCombo.SelectedIndex = 0;
            // загружаем список названий типов товаров
            List<string> lstTypes = Program.db.ProductType.Select(a => a.Title).ToList();
            lstTypes.Insert(0, "Все типы");
            // передаем данные фильтру
            FiltrCombo.DataSource = lstTypes;

            // подготавливаем коллекцию Пользователских ЭУ
            // размещаем ее в flowLayoutPanel1
            for (int i = 0; i < nProdList; i++)
            {
                // добавляем новый ПЭУ к коллекции lstControls
                lstControls.Add(new ProductUserCntrl());
                // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                // подключаем обработчик события Notify
                lstControls[i].Notify += Notify;
                // добавляем новый ПЭУ к flowLayoutPanel 
                flowLayoutPanel1.Controls.Add(lstControls[i]);
            }

            //  заносим кнопки в массив для удобства работы
            {
                btnsList[0] = button1;
                btnsList[1] = button2;
                btnsList[2] = button3;
                btnsList[3] = button4;
                btnsList[4] = button5;
                // делаем активной первую кнопку
                nPageFirst = nPageCurrent = 1;  // на всякий случай ???
                ShowButtons(nPageFirst, nPageCurrent);
            }

            // подготавливаем данные для показа
            PodgotovkaData();
        }
        /////////////////////////////////////////////////
        // параметры показа продукции 
        string filtr = "Все типы";      // фильтр показа продукции;
        string sort = "Без сортировки"; // сортировки продукции
        string sortDirection = "возрастание"; // направление сортировки
        string search = "";             // поиск по наименованию и описанию

        /////////////////////////////////////////////////
        //  Подготовка данных для показа 
        public void PodgotovkaData()
        {
            // вначале выбираем все товары
            lstProduct = Program.db.Product.ToList();

            /////////////////////////////////////////////            
            // фильтрация по типам товаров
            if (filtr != "Все типы")
            {
                // отбираем только по заданному производителю
                lstProduct = lstProduct.Where(p => (p.ProductType.Title == filtr)).ToList();
            }
            /////////////////////////////////////////////
            // поиск по заданной строке
            if (search != "")
            {   // отбираем товары с заданной строкой в названии
                search = search.ToUpper();
                // поиск с учетом регистра
                // ToUpper() для пустой строки не срабатывает
                lstProduct = lstProduct
                    .Where(p => (p.Title.ToUpper().Contains(search)) ||
                        (p.Description != null && // есть описание ?
                         p.Description.ToUpper().Contains(search)))
                    .ToList();
            }
            /////////////////////////////////////////////
            // сортировка по разным полям
            if (sort == "Без сортировки")
            {
                if (sort == "Наименование")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheck.Checked)
                        lstProduct = lstProduct.OrderBy(p => p.Title).ToList();
                    else
                        lstProduct = lstProduct.
                            OrderByDescending(p => p.Title).ToList();
                }
                if (sort == "Номер цеха")
                {   // сортируем отобранные товары по наименованию
                    if (sortDirection == "возрастание")
                        lstProduct = lstProduct.OrderBy(p => p.ProductionWorkshopNumber).ToList();
                    else
                        lstProduct = lstProduct.
                            OrderByDescending(p => p.ProductionWorkshopNumber).ToList();
                }
                if (sort == "Мин.стоимость")
                {   // сортируем отобранные товары по наименованию
                    if (!DownCheck.Checked)
                        lstProduct = lstProduct.OrderBy(p => p.MinCostForAgent).ToList();
                    else
                        lstProduct = lstProduct.
                            OrderByDescending(p => p.MinCostForAgent).ToList();
                }
            }            

            // что показываем на кнопках 
            nPageCurrent = 1;       // текущая - первая страница
            nPageFirst = 1;         // первая кнопка  - первая страница
            // расчитываем общее кол-во страниц (после фильтрации и поиска)
            nPageAll = lstProduct.Count() / nProdList;            
            if (nPageAll * nProdList < lstProduct.Count())
                nPageAll++;
            // если страниц меньше, чем кнопок
            //if(nPageAll <= numButtons)
            //{
            //    for (int i = nPageAll; i <= 5; i++)
            //        btnsList[i - 1].Enabled = false;
            //    RightBtn.Enabled = false;
            //}

            /////////////////////////////////////////////
            // вызываем показ первой страницы 
            ShowCurrentPage();
        }

        /////////////////////////////////////////////////
        // метод загрузки данных в ПЭУ  
        private void ShowCurrentPage()
        {
            int nProdMax = lstProduct.Count(); // максимальное коли-во товара

            // если данный товар выбран, то показываем кнопку "Изменить стоимость"
            if (lstSelectedProduct.Count > 0)
                CostChangeBtn.Visible = true;
            else
                CostChangeBtn.Visible = false;

            // установка счетчика номера товара на странице
            int i = (nPageCurrent - 1) * nProdList;

            // цикл по UserControls, которые будут показываться на форме 
            // задаем свойства показываемых ПЭУ
            foreach (ProductUserCntrl puc in lstControls)
            {// каждому UserControls передаем данные (с помощью свойств)
             // проверяем, есть ли данные для очередного UserControls
                if (i < nProdMax)
                {
                    // сохраняем ID продукта
                    puc.ID = lstProduct[i].ID;

                    // проверяем - выбран этот ЭУ или нет?
                    if (lstSelectedProduct.IndexOf(puc.ID) != -1)
                    {// если данный ПЭУ ВЫБРАН, то фон меняем
                        puc.BackColor = Color.LightGray;
                    }
                    else
                    {// если не выбран, то начальный цвет
                        puc.BackColor = Color.White; // puc.BackColor1;
                    }
                    // задаем фото товара
                    if ((lstProduct[i].Image != "") && (lstProduct[i].Image != null))
                        // если фото у товара есть, добавляем его
                        puc.Picture = Image.FromFile(lstProduct[i].Image);
                    else  // если фото нет, то добавляем картинку по умолчанию
                        puc.Picture = Image.FromFile(@"products\picture.png");

                    // задаем строку "тип товара | название товара"
                    puc.TypeNameProduct = lstProduct[i].ProductType.Title + " | "
                        + lstProduct[i].Title;

                    // задаем артикул товара
                    puc.Articul = lstProduct[i].ArticleNumber;

                    // задаем список материалов и стоимость товара
                    // они составляются из списка товаров              
                    double cost = 0;
                    string mtr = "";
                    foreach (ProductMaterial prd_mtr in lstProduct[i].ProductMaterial)
                    {
                        if (prd_mtr.Count.HasValue)
                        {
                            if (mtr != "") mtr += ", ";
                            mtr += prd_mtr.Material.Title;
                            double n = prd_mtr.Count.Value;
                            cost += n * Convert.ToDouble(prd_mtr.Material.Cost);
                        }
                    }
                    puc.Material = mtr;
                    puc.Cost = cost;

                    // задаем цех производства товара, если задан 
                    if (lstProduct[i].ProductionWorkshopNumber.HasValue)
                    {
                        puc.WorkshopNumber = lstProduct[i].ProductionWorkshopNumber.Value;
                    }

                    //  задаем миним. стоимость для агента
                    puc.MinCost = Convert.ToDouble(lstProduct[i].MinCostForAgent);

                    // делаем данный ЭУ видимым 
                    puc.Visible = true;
                }
                else
                {   // если данных для ПЭУ нет
                    // делаем этот ПЭУ невидимым
                    puc.Visible = false;
                    // если данных уже нет, то кнопка враво не активная
                    RightBtn.Enabled = false;
                }
                i++; // счетчик номера товара увеличиваем
            }
            // если на последней странице показаны все товары
            // то кнопку тоже отключаем 
            if (i == nProdMax)
            {
                RightBtn.Enabled = false;
            }
            //////////////////////////////////////////////////////////
            //  выводим надпись внизу формы 
            // 
            int beginProdNumber = (nPageCurrent - 1) * nProdList + 1;
            int endProdNumber = nPageCurrent * nProdList;
            if (endProdNumber > nProdMax) endProdNumber = nProdMax;
            //  вывод сообщения о номерах показываемых товаров
            
            RangeLbl.Text = $"Товары с {beginProdNumber} по {endProdNumber} (из всего {lstProduct.Count()})";
        }        

        ////////////////////////////////////////////////////////
        //  обработчики событий - сортировка, поиск, фильтрация
        private void SortCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = SortCombo.Text;
            PodgotovkaData();
        }
        private void DownCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (DownCheck.Checked)
                sortDirection = "убывание";
            else
                sortDirection = "возрастание";
            PodgotovkaData();
        }
        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            search = SearchTxt.Text;
            PodgotovkaData();
        }

        private void FiltrCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtr = FiltrCombo.Text;
            PodgotovkaData();
        }

        /////////////////////////////////////////////////////////////
        //  нажата кнопка "Добавить"
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddEditProductForm form = new AddEditProductForm();
            form.prd = null;
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PodgotovkaData();
                ShowCurrentPage();
            }
        }

        /////////////////////////////////////////////////////////////
        // обработчик события от пользовательского ЭУ
        private void Notify(string message, int id)
        {
            if (message == "Правая кнопка")
            {
                if (lstSelectedProduct.Count > 0)
                    CostChangeBtn.Visible = true;
                else
                    CostChangeBtn.Visible = false;
            }
            if (message == "Левая кнопка")
            {
                // при нажатии левой клавиши показываем окно "Изменение товара"
                AddEditProductForm form = new AddEditProductForm();
                // ищем товар, по которому выполнен щелчок левой кнопки мыши
                Product prd = lstProduct.Find(p => p.ID == id);
                form.prd = prd;
                DialogResult dr = form.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    PodgotovkaData();
                    ShowCurrentPage();
                }
            }
        }

        //  нажата кнопка "Изменить мин. стоимость ..."
        private void CostChangeBtn_Click(object sender, EventArgs e)
        {
            CostChangeForm form = new CostChangeForm();
            DialogResult dr = form.ShowDialog();
            if (dr == DialogResult.OK)
            {
                PodgotovkaData();
                ShowCurrentPage();
            }
        }

        ////////////////////////////////////////////////////////
        // работа с кнопками перехода между страницами !!!!!!!!!        
        /////////////////////////////////////////////////////////// 
        int nPageAll = 0;     // всего страниц
        int nPageFirst = 1;   // номер показываемой первой страницы
        int nPageCurrent = 1; // номер выделенной текущей страницы        
        // кнопка перехода к предыдущей странице товаров
        private void LeftBtn_Click(object sender, EventArgs e)
        {
            // вычисляем номер предыдущей страницы
            if (nPageCurrent > 1) 
            {
                nPageCurrent--;
                if (nPageCurrent < nPageFirst)
                    nPageFirst--;
                ShowButtons(nPageFirst, nPageCurrent);
            }            
            //  задаем состояние кнопок влево - вправо
            LeftBtn.Enabled = true;
            if (nPageCurrent == 1 && nPageFirst == 1) // влево двигаться некуда
                LeftBtn.Enabled = false;

            RightBtn.Enabled = false;
            if (nPageFirst + (numButtons - 1) < nPageAll) // вправо двигаться есть куда
                RightBtn.Enabled = true;

            // показываем новую страницу
            ShowCurrentPage();
        }
        ////////////////////////////////////////////////////////       
        // переход к следующей странице товаров
        private void RightBtn_Click(object sender, EventArgs e)
        {
            // вычисляем начальный номер товара на следующей странице
            if (nPageCurrent < nPageAll)
            {
                // вычисляем номер следующей страницы
                nPageCurrent++;
                if (nPageCurrent > (nPageFirst + (numButtons - 1))) // вышли за верхний предел страниц
                    nPageFirst++;
                // перерисовываем кнопки
                ShowButtons(nPageFirst, nPageCurrent);
            }
            
            LeftBtn.Enabled = true;

            RightBtn.Enabled = false;
            if (nPageFirst + (numButtons - 1) < nPageAll) // вправо двигаться есть куда
                RightBtn.Enabled = true;

            // показываем новую страницу
            ShowCurrentPage();
        }
        ////////////////////////////////////////////////////////
        //  нажатие одной из кнопок 
        private void buttonN_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // определяем номер показываемой страницы
            nPageCurrent = Convert.ToInt32(btn.Text);

            // показываем все кнопки с выделением активной
            ShowButtons(nPageFirst, nPageCurrent);
            // загружаем данные в другую страницу            
            ShowCurrentPage();
        }

        //
        // Рисуем все кнопки с выделением текущей
        //
        void ShowButtons(int nPageFirst, int nPageCurrent)
        {
            for (int i = 0; i < numButtons; i++)
            {
                btnsList[i].Text = (nPageFirst + i).ToString();
                
                if ((nPageFirst + i) == nPageCurrent)
                    btnsList[i].BackColor = Color.LightBlue;
                else
                    btnsList[i].BackColor = Color.White;
            }
        }
    }
}
