using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopushokApp
{
    public partial class ProductUserCntrl : UserControl
    {
        // закрытые поля пользовательского ЭУ
        public int ID;
        //private Color colFColor;
        private Color colBColor;
        private Image pictureImg;
        private string typeNameProductStr;
        private string articulStr;
        private string materialStr;
        private double costDbl;
        private int workshopNumber;
        private double minCost;

        ///////////////////////////////////////////////////////
        // описываем свое собственное событие 
        public delegate void MyHandler(string message, int id);
        public event MyHandler Notify;

        public ProductUserCntrl()
        {
            InitializeComponent();
            // запоминаем цвет фона ЭУ при создании
            //BackColor1 = BackColor;
        }

        private void ProductUserCntrl_Load(object sender, EventArgs e)
        {            
           
        }
        
        //  свойство - Picture - изображение 
        public Image Picture
        {
            get { return pictureImg; }
            set
            {
                pictureImg = value;
                PictureBox.Image = pictureImg;
            }
        }

        //  свойство - тип и название товара
        public string TypeNameProduct
        {
            get{ return typeNameProductStr; }
            set
            {
                typeNameProductStr = value;
                TypeNameProductLbl.Text = typeNameProductStr;
            }
        }
        //  свойство - артикул товара
        public string Articul
        {
            get{ return articulStr; }
            set
            {
                articulStr = value;
                ArticulLbl.Text = articulStr;
            }
        }
        //  свойство - список материалов, из которых сделан товар
        public string Material
        {
            get { return materialStr; }
            set
            {
                materialStr = value;
                MaterialLbl.Text = materialStr;
            }
        }
        //  свойство стоимости товара
        public double Cost
        {
            get{ return costDbl; }
            set
            {
                costDbl = value;
                CostLbl.Text = costDbl.ToString();
            }
        }
        //  свойство - номер цеха
        public int WorkshopNumber
        {
            get { return workshopNumber; }
            set
            {
                workshopNumber = value;
                WorkshopLbl.Text = workshopNumber.ToString();
            }
        }
        public double MinCost
        {
            get { return minCost; }
            set
            {
                minCost = value;
                MinCostLbl.Text = minCost.ToString();
            }
        }

        //////////////////////////////////////////////////////////////////////////
        // обработчик события - щелчок левой или правой кнопкой мыши
        private void ProductUserCntrl_MouseClick(object sender, MouseEventArgs e)
        {
            ////////////////////////////////////////////////////////////////////
            // вызываем свое событие Notify()
            // проверяем, что к событию подключен хотя бы один обработчик
            // 
            if(e.Button == MouseButtons.Right)
            {
                if (Form1.lstSelectedProduct.IndexOf(ID) != -1)
                { // если данный ПЭУ ВЫБРАН
                    BackColor = colBColor;
                    // удаляем из выборанных
                    Form1.lstSelectedProduct.Remove(ID);
                }
                else
                { // если данный ПЭУ НЕ ВЫБРАН
                    BackColor = Color.LightGray;
                    // добавляем к выбранным
                    Form1.lstSelectedProduct.Add(ID);
                }
                //  если нажата правая кнопка мыши
                //  вызываем срабатывание события в котором передаем,
                //  1) нажата правая кнопка мыши и 2) ID элемента управления
                if (Notify != null) Notify("Правая кнопка", ID);
            }
            if(e.Button == MouseButtons.Left)
            {   //  если нажата левая кнопка мыши
                //  вызываем срабатывание события в котором передаем,
                //  1) нажата левая кнопка мыши и 2) ID элемента управления
                if (Notify != null) Notify("Левая кнопка", ID);
            }
        }
    }
}
