using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Da;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using Oracle.ManagedDataAccess.Client;
using Telerik.WinControls.UI;

namespace Presentation
{
    public partial class Chart : Form
    {
        private bool flag;
        private int state = 1;
        const int size = 100;
        float[] PEC = new float[size];
        float TotalSumBuy = 0;
        float TotalSumSell = 0;

        readonly float[] sell =new float[size];
        readonly float[] buy =new float[size];

        string[] day = new string[size];

        string[] kalaName =new string[size];
        int[] kalaPrice =new int[size];
        int[] kalaCount = new int[size];

        string[] Moshtari = new string[size];
        int[] PriceMoshtari =new int[size];

        int[] sellPrice = new int[size];
        string[] Selldate = new string[size];

        int[] buyPrice = new int[size];
        string[] buyDate=new string[size];

        private int index = 0;

        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            DataAccess.Connect();
            OracleCommand cmd = new  OracleCommand("select * from factor_froosh", DataAccess.connection);
            OracleCommand cmd2 = new OracleCommand("select * from factor_kharid", DataAccess.connection);
            OracleCommand cmd3 =new OracleCommand("select  factor_froosh.price , moshtari.name , FACTOR_FROOSH.FACTOR_DAY  from moshtari,factor_froosh where  moshtari.id = factor_froosh.Idmoshtari", DataAccess.connection);
            OracleCommand cmd4 =new OracleCommand("select FACTOR_KHARID.PRICE , FACTOR_FROOSH.PRICE from FACTOR_FROOSH,FACTOR_KHARID where FACTOR_FROOSH.IDKALA = FACTOR_KHARID.IDKALA", DataAccess.connection);
            OracleCommand cmd5 =new OracleCommand("select kala.name,kala.PRICE,FACTOR_KHARID.COUNT from kala,FACTOR_KHARID where kala.ID = FACTOR_KHARID.IDKALA", DataAccess.connection);

            OracleDataReader reader  = cmd.ExecuteReader();
            OracleDataReader reader2 = cmd2.ExecuteReader();
            OracleDataReader reader3 = cmd3.ExecuteReader();
            OracleDataReader reader4 = cmd4.ExecuteReader();
            OracleDataReader reader5 = cmd5.ExecuteReader();

            while (reader.Read())
            {
                sellPrice[index] = reader.GetInt32(3);
                Selldate[index]  = reader.GetString(5);
                chFroosh.Series["Price"].Points.Add(new SeriesPoint(Selldate[index], sellPrice[index]));
                ++index;
            }
            index = 0;
            while (reader2.Read())
            {
                buyPrice[index] = reader2.GetInt32(3);
                buyDate[index] = reader2.GetString(5);
                chKharid.Series["Price"].Points.Add(new SeriesPoint(buyDate[index], buyPrice[index]));
                ++index;
            }
            index = 0;
            while (reader3.Read())
            {
                PriceMoshtari[index] = reader3.GetInt32(0);
                Moshtari[index] = reader3.GetString(1);
                day[index] = reader3.GetString(2);
                chMoshtari.Series["Price"].Points.Add(new SeriesPoint(Moshtari[index],PriceMoshtari[index].ToString()));
                chMoshtari.Series["Date"].Points.Add(new SeriesPoint(day[index], PriceMoshtari[index]));
                ++index;
            }
            index = 0;
            while (reader4.Read())
            {
                buy[index] =  reader4.GetInt32(0);
                sell[index] = reader4.GetInt32(1);
                TotalSumBuy += buy[index];
                TotalSumSell += sell[index];
                chProfit.Series["Price"].Points.Add(new SeriesPoint(buy[index], sell[index]));
                ++index;
            }
            float profit = (TotalSumSell - TotalSumBuy)/TotalSumBuy*100;
            lblProfit.Text =profit.ToString();
            index = 0;
            while (reader5.Read())
            {
                kalaName[index]  = reader5.GetString(0);
                kalaPrice[index] = reader5.GetInt32(1);
                kalaCount[index] = reader5.GetInt32(2);
                chKala.Series["Price"].Points.Add(new SeriesPoint(kalaName[index], kalaPrice[index]));
                chCount.Series["Count"].Points.Add(new SeriesPoint(kalaName[index], kalaCount[index]));
                ++index;
            }
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            ChartControl chart = sender as ChartControl;
            string name = chart.Name;
            switch (name)
            {
                case "chFroosh":
                    lblFroosh.Left += 100;
                    chFroosh.Width += 200;
                    chFroosh.Height += 200;
                    chFroosh.Border.Color = Color.Red;
                    lblKharid.Visible = false;
                    chFroosh.Border.Visibility=DefaultBoolean.True;
                    chFroosh.Border.Thickness = 1;
                    chKharid.SendToBack();
                    chProfit.SendToBack();
                    chCount.SendToBack();
                    label5.SendToBack();
                    lblProfit.SendToBack();
                    label2.SendToBack();
                    label3.SendToBack();
                    break;
                case "chKharid":
                    chKharid.Width += 200;
                    lblKharid.Left += 100;
                    chKharid.Height += 200;
                    chKharid.Border.Color = Color.Red;
                    chKharid.Border.Visibility = DefaultBoolean.True;
                    label4.SendToBack();
                    chKala.SendToBack();
                    label5.SendToBack();
                    chFroosh.Border.Thickness = 1;
                    chMoshtari.SendToBack();
                    chFroosh.SendToBack();
                    break;
                case "chMoshtari":
                    chMoshtari.Width += 200;
                    lblKharid.Left += 100;
                    chMoshtari.Height += 200;
                    chMoshtari.Border.Color = Color.Red;
                    chMoshtari.Border.Visibility = DefaultBoolean.True;
                    chMoshtari.Border.Thickness = 1;
                    label4.SendToBack();
                    chCount.SendToBack();
                    chKala.SendToBack();
                    break;
                case "chProfit":
                    chProfit.Width += 150;
                    chProfit.Height += 150;
                    chProfit.Border.Color = Color.Red;
                    chProfit.Border.Visibility = DefaultBoolean.True;
                    chProfit.Border.Thickness = 1;
                    break;
                  case "chKala":
                    chKala.Width  += 150;
                    chKala.Height += 150;
                    chKala.Border.Color = Color.Red;
                    chKala.Border.Visibility = DefaultBoolean.True;
                    chKala.Border.Thickness = 1;
                    break;
                case "chCount":
                    chCount.Width += 150;
                    chCount.Height += 150;
                    chCount.Border.Color = Color.Red;
                    chCount.Border.Visibility = DefaultBoolean.True;
                    chCount.Border.Thickness = 1;
                    chKala.SendToBack();
                    break;
            }
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            ChartControl chart = sender as ChartControl;
            string name = chart.Name;
            switch (name)
            {
                case "chFroosh":
                    lblKharid.Visible = true;
                    chFroosh.Width -= 200;
                    lblFroosh.Left -= 100;
                    chFroosh.Height -= 200;
                    chFroosh.Border.Visibility = DefaultBoolean.False;
                    break;
                case "chKharid":
                    chKharid.Width -= 200;
                    lblKharid.Left -= 100;
                    chKharid.Height -= 200;
                    chKharid.Border.Visibility = DefaultBoolean.False;
                    break;
                case "chMoshtari":
                    chMoshtari.Width -= 200;
                    lblKharid.Left -= 100;
                    chMoshtari.Height -= 200;
                    chMoshtari.Border.Visibility = DefaultBoolean.False;
                    break;
                case "chProfit":
                    chProfit.Width -= 150;
                    chProfit.Height -= 150;
                    chProfit.Border.Visibility = DefaultBoolean.False;
                    break;
                case "chKala":
                    chKala.Width -= 150;
                    chKala.Height -= 150;
                    chKala.Border.Visibility = DefaultBoolean.False;
                    break;
                case "chCount":
                    chCount.Width -= 150;
                    chCount.Height -= 150;
                    chCount.Border.Visibility = DefaultBoolean.False;
                    break;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (panelEx1.Width >= 265)
                {
                    pictureBox1.Visible = true;
                    comoFroosh.Visible = true;
                    comboKharid.Visible = true;
                    comboMoshtari.Visible = true;
                    comboProfit.Visible = true;
                    comboKalaCount.Visible = true;
                    comboKalaPrice.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    picClose.Visible = false;
                    timer.Stop();
                }
                else
                {
                    panelEx1.Width += 10;
                }
            }
            else if(flag==false)
            {
                if (panelEx1.Width <= 80)
                {
                    
                    timer.Stop();
                }
                else
                {
                    panelEx1.Width -= 10;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                pictureBox2.Image = Properties.Resources.backMenu;
                flag = true;
                timer.Start();
            }
            else if(state==-1)
            {
                pictureBox2.Image = Properties.Resources._1463941353_menu_alt;
                flag = false;
                pictureBox1.Visible = false;
                comoFroosh.Visible = false;
                comboKharid.Visible = false;
                comboMoshtari.Visible = false;
                comboProfit.Visible = false;
                comboKalaCount.Visible = false;
                comboKalaPrice.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                picClose.Visible = true;
                timer.Start();
            }

            state *= -1;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DataAccess.Disconnect();
            this.Close();
        }

        private void ValueChange(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            string name = cmb.Name;

            switch (name)
            {
                case "comoFroosh":
                    if (comoFroosh.Text == "pie")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Pie);
                    }
                    else if (comoFroosh.Text == "Pie3D")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Pie3D);
                    }
                    else if (comoFroosh.Text == "Line")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Line);
                    }
                    else if (comoFroosh.Text == "Line3D")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Line3D);
                    }
                    else if (comoFroosh.Text == "Spline")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Spline);
                    }
                    else if (comoFroosh.Text == "Spline3D")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Spline3D);
                    }
                    else if (comoFroosh.Text == "Bar")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Bar);
                    }
                    else if (comoFroosh.Text == "Bar3D")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.Bar3D);
                    }
                    else if (comoFroosh.Text == "StepLine")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.StepLine);
                    }
                    else if (comoFroosh.Text == "StepLine3D")
                    {
                        chFroosh.Series["Price"].ChangeView(ViewType.StepLine3D);
                    }
                    break;
                case "comboKharid":
                    if (comboKharid.Text == "pie")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Pie);
                    }
                    else if (comboKharid.Text == "Pie3D")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Pie3D);
                    }
                    else if (comboKharid.Text == "Line")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Line);
                    }
                    else if (comboKharid.Text == "Line3D")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Line3D);
                    }
                    else if (comboKharid.Text == "Spline")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Spline);
                    }
                    else if (comboKharid.Text == "Spline3D")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Spline3D);
                    }
                    else if (comboKharid.Text == "Bar")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Bar);
                    }
                    else if (comboKharid.Text == "Bar3D")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.Bar3D);
                    }
                    else if (comboKharid.Text == "StepLine")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.StepLine);
                    }
                    else if (comboKharid.Text == "StepLine3D")
                    {
                        chKharid.Series["Price"].ChangeView(ViewType.StepLine3D);
                    }
                    break;
                case "comboMoshtari":
                    if (comboMoshtari.Text == "pie")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Pie);
                    }
                    else if (comboMoshtari.Text == "Pie3D")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Pie3D);
                    }
                    else if (comboMoshtari.Text == "Line")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Line);
                    }
                    else if (comboMoshtari.Text == "Line3D")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Line3D);
                    }
                    else if (comboMoshtari.Text == "Spline")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Spline);
                    }
                    else if (comboMoshtari.Text == "Spline3D")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Spline3D);
                    }
                    else if (comboMoshtari.Text == "Bar")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Bar);
                    }
                    else if (comboMoshtari.Text == "Bar3D")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.Bar3D);
                    }
                    else if (comboMoshtari.Text == "StepLine")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.StepLine);
                    }
                    else if (comboMoshtari.Text == "StepLine3D")
                    {
                        chMoshtari.Series["Price"].ChangeView(ViewType.StepLine3D);
                    }
                    break;
                case "comboProfit":
                    if (comboProfit.Text == "pie")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Pie);
                    }
                    else if (comboProfit.Text == "Pie3D")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Pie3D);
                    }
                    else if (comboProfit.Text == "Line")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Line);
                    }
                    else if (comboProfit.Text == "Line3D")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Line3D);
                    }
                    else if (comboProfit.Text == "Spline")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Spline);
                    }
                    else if (comboProfit.Text == "Spline3D")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Spline3D);
                    }
                    else if (comboProfit.Text == "Bar")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Bar);
                    }
                    else if (comboProfit.Text == "Bar3D")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.Bar3D);
                    }
                    else if (comboProfit.Text == "StepLine")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.StepLine);
                    }
                    else if (comboProfit.Text == "StepLine3D")
                    {
                        chProfit.Series["Price"].ChangeView(ViewType.StepLine3D);
                    }
                    break;
                case "comboKalaCount":
                    if (comboKalaCount.Text == "pie")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Pie);
                    }
                    else if (comboKalaCount.Text == "Pie3D")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Pie3D);
                    }
                    else if (comboKalaCount.Text == "Line")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Line);
                    }
                    else if (comboKalaCount.Text == "Line3D")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Line3D);
                    }
                    else if (comboKalaCount.Text == "Spline")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Spline);
                    }
                    else if (comboKalaCount.Text == "Spline3D")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Spline3D);
                    }
                    else if (comboKalaCount.Text == "Bar")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Bar);
                    }
                    else if (comboKalaCount.Text == "Bar3D")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.Bar3D);
                    }
                    else if (comboKalaCount.Text == "StepLine")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.StepLine);
                    }
                    else if (comboKalaCount.Text == "StepLine3D")
                    {
                        chCount.Series["Count"].ChangeView(ViewType.StepLine3D);
                    }
                    break;
                case "comboKalaPrice":
                    if (comboKalaPrice.Text == "pie")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Pie);
                    }
                    else if (comboKalaPrice.Text == "Pie3D")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Pie3D);
                    }
                    else if (comboKalaPrice.Text == "Line")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Line);
                    }
                    else if (comboKalaPrice.Text == "Line3D")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Line3D);
                    }
                    else if (comboKalaPrice.Text == "Spline")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Spline);
                    }
                    else if (comboKalaPrice.Text == "Spline3D")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Spline3D);
                    }
                    else if (comboKalaPrice.Text == "Bar")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Bar);
                    }
                    else if (comboKalaPrice.Text == "Bar3D")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.Bar3D);
                    }
                    else if (comboKalaPrice.Text == "StepLine")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.StepLine);
                    }
                    else if (comboKalaPrice.Text == "StepLine3D")
                    {
                        chKala.Series["Price"].ChangeView(ViewType.StepLine3D);
                    }
                    break;
            }

        }
    }
}
