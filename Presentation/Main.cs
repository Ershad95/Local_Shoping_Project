
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using Da;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;

namespace Presentation
{
    public partial class Main : Form
    {
        OracleDataAdapter dap = new OracleDataAdapter();
        DataTable dt = new DataTable();
        private PictureBox pic;
        private int st = -1;
        bool fisrtClick = true;
        DataAccess d = new DataAccess();

        enum theame
        {
            green,
            blue,
            gold,
            black
        }

        CultureInfo cinfo;
        theame the = theame.green;

        public Main()
        {
            InitializeComponent();
            d.cmdm.Connection = DataAccess.connection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Write("Connect to DB");
            Player.URL = @"Play.mp3";
            Player.Ctlcontrols.play();
            string thestr = Properties.Settings.Default.Theame;

            switch (thestr)
            {
                case "black":
                    lbledit.ForeColor = Color.White;
                    the = theame.black;
                    Properties.Settings.Default.Save();
                    lblFooter.ForeColor = lbltime.ForeColor = Color.White;
                    lblheader.ForeColor = Color.White;
                    information.Style.BackColor = Color.Gray;
                    information.Style.BackColor2 = Color.Black;

                    Footer.BackColor = Header.BackColor = Color.DimGray;
                    mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.Gray;
                    this.BackColor = Color.Black;


                    txtID.BackColor =
                        txtName.BackColor =
                            txtFamily.BackColor =
                                txtTel.BackColor = Color.Wheat;
                    ADD.BackColor = Color.DimGray;

                    lang_fa.BackColor =
                        lang_en.BackColor =
                            PROGRMMER.BackColor =
                                CURRENT_VER.BackColor =
                                    PASS_recovery.BackColor =
                                        PASS_change.BackColor =
                                            theGreen.BackColor =
                                                theGold.BackColor =
                                                    theBlue.BackColor =
                                                        theBlack.BackColor =
                                                            UPDATE_k.BackColor =
                                                                UPDATE_F.BackColor =
                                                                    DELETE_f.BackColor =
                                                                        UPDATE_M.BackColor =
                                                                            UPDATE_update.BackColor =
                                                                                DELETE_M.BackColor =
                                                                                    DELETE_K.BackColor =
                                                                                        ADD_M.BackColor =
                                                                                            ADD_K.BackColor =
                                                                                                theFont.BackColor =
                                                                                                    ADD_F.BackColor =
                                                                                                        Color.SlateGray;
                    break;
                case "green":
                    lbledit.ForeColor = Color.Black;
                    the = theame.green;
                    Properties.Settings.Default.Save();
                    lblFooter.ForeColor = lbltime.ForeColor = Color.Black;
                    lblheader.ForeColor = Color.Black;
                    information.Style.BackColor = Color.LimeGreen;
                    information.Style.BackColor2 = Color.Black;

                    Footer.BackColor = Header.BackColor = Color.SpringGreen;
                    mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.Lime;
                    this.BackColor = Color.Green;
                    txtID.BackColor =
                        txtName.BackColor =
                            txtFamily.BackColor =
                                txtTel.BackColor = Color.PaleGreen;
                    ADD.BackColor = Color.SpringGreen;
                    lang_fa.BackColor =
                        lang_en.BackColor =
                            PROGRMMER.BackColor =
                                CURRENT_VER.BackColor =
                                    PASS_recovery.BackColor =
                                        PASS_change.BackColor =
                                            theGreen.BackColor =
                                                theGold.BackColor =
                                                    theBlue.BackColor =
                                                        theBlack.BackColor =
                                                            UPDATE_k.BackColor =
                                                                UPDATE_F.BackColor =
                                                                    DELETE_f.BackColor =
                                                                        UPDATE_M.BackColor =
                                                                            UPDATE_update.BackColor =
                                                                                DELETE_M.BackColor =
                                                                                    DELETE_K.BackColor =
                                                                                        ADD_M.BackColor =
                                                                                            ADD_K.BackColor =
                                                                                                theFont.BackColor =
                                                                                                    ADD_F.BackColor =
                                                                                                        Color
                                                                                                            .GreenYellow;
                    break;
                case "blue":
                    lbledit.ForeColor = Color.Black;
                    the = theame.blue;
                    Properties.Settings.Default.Save();
                    lblFooter.ForeColor = lbltime.ForeColor = Color.Black;
                    lblheader.ForeColor = Color.Black;
                    information.Style.BackColor = Color.CornflowerBlue;
                    information.Style.BackColor2 = Color.MidnightBlue;
                    information.Style.TextColor = Color.White;
                    Footer.BackColor = Header.BackColor = Color.DeepSkyBlue;
                    mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.CornflowerBlue;
                    this.BackColor = Color.Blue;
                    txtID.BackColor =
                        txtName.BackColor =
                            txtFamily.BackColor =
                                txtTel.BackColor = Color.White;

                    lang_fa.BackColor =
                        lang_en.BackColor =
                            PROGRMMER.BackColor =
                                CURRENT_VER.BackColor =
                                    PASS_recovery.BackColor =
                                        PASS_change.BackColor =
                                            theGreen.BackColor =
                                                theGold.BackColor =
                                                    theBlue.BackColor =
                                                        theBlack.BackColor =
                                                            UPDATE_k.BackColor =
                                                                UPDATE_F.BackColor =
                                                                    DELETE_f.BackColor =
                                                                        UPDATE_M.BackColor =
                                                                            UPDATE_update.BackColor =
                                                                                DELETE_M.BackColor =
                                                                                    DELETE_K.BackColor =
                                                                                        ADD.BackColor =
                                                                                            ADD_M.BackColor =
                                                                                                ADD_K.BackColor =
                                                                                                    theFont.BackColor =
                                                                                                        ADD_F.BackColor
                                                                                                            =
                                                                                                            Color
                                                                                                                .DeepSkyBlue;
                    break;
                case "gold":
                    lbledit.ForeColor = Color.Black;
                    the = theame.gold;
                    Properties.Settings.Default.Save();
                    lblFooter.ForeColor = lbltime.ForeColor = Color.Black;
                    lblheader.ForeColor = Color.Black;
                    information.Style.BackColor = Color.OrangeRed;
                    information.Style.BackColor2 = Color.Goldenrod;
                    information.Style.TextColor = Color.White;
                    Footer.BackColor = Header.BackColor = Color.Yellow;
                    mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.Gold;
                    this.BackColor = Color.Khaki;
                    ADD.BackColor = Color.Yellow;
                    txtID.BackColor =
                        txtName.BackColor =
                            txtFamily.BackColor =
                                txtTel.BackColor = Color.Yellow;

                    lang_fa.BackColor =
                        lang_en.BackColor =
                            PROGRMMER.BackColor =
                                CURRENT_VER.BackColor =
                                    PASS_recovery.BackColor =
                                        PASS_change.BackColor =
                                            theGreen.BackColor =
                                                theGold.BackColor =
                                                    theBlue.BackColor =
                                                        theBlack.BackColor =
                                                            UPDATE_k.BackColor =
                                                                UPDATE_F.BackColor =
                                                                    DELETE_f.BackColor =
                                                                        UPDATE_M.BackColor =
                                                                            UPDATE_update.BackColor =
                                                                                DELETE_M.BackColor =
                                                                                    DELETE_K.BackColor =
                                                                                        ADD_M.BackColor =
                                                                                            ADD_K.BackColor =
                                                                                                theFont.BackColor =
                                                                                                    ADD_F.BackColor =
                                                                                                        Color.Orange;

                    break;
            }

            String s = txtName.Text;
            bool b = s.Contains("yahoo");
            if (b)
            {
                MessageBox.Show("true");
            }

            timer.Enabled = true;
            timer.Start();
        }

        private void changeThe(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Name;
            switch (name)
            {
                case "theGreen":

                    {
                        the = theame.green;
                        lblFooter.ForeColor = lbltime.ForeColor = Color.Black;
                        lblheader.ForeColor = Color.Black;
                        lbledit.ForeColor = Color.Black;
                        information.Style.BackColor = Color.LimeGreen;
                        information.Style.BackColor2 = Color.Black;

                        Footer.BackColor = Header.BackColor = Color.SpringGreen;
                        mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.Lime;
                        this.BackColor = Color.Green;


                        txtID.BackColor =
                            txtName.BackColor =
                                txtFamily.BackColor =
                                    txtTel.BackColor = Color.PaleGreen;
                        ADD.BackColor = Color.SpringGreen;
                        lang_fa.BackColor =
                            lang_en.BackColor =
                                PROGRMMER.BackColor =
                                    CURRENT_VER.BackColor =
                                        PASS_recovery.BackColor =
                                            PASS_change.BackColor =
                                                theGreen.BackColor =
                                                    theGold.BackColor =
                                                        theBlue.BackColor =
                                                            theBlack.BackColor =
                                                                UPDATE_k.BackColor =
                                                                    UPDATE_F.BackColor =
                                                                        DELETE_f.BackColor =
                                                                            UPDATE_M.BackColor =
                                                                                UPDATE_update.BackColor =
                                                                                    DELETE_M.BackColor =
                                                                                        DELETE_K.BackColor =
                                                                                            ADD_M.BackColor =
                                                                                                ADD_K.BackColor =
                                                                                                    theFont.BackColor =
                                                                                                        ADD_F.BackColor =
                                                                                                            Color
                                                                                                                .GreenYellow;
                    }

                    break;
                case "theBlue":
                    {
                        lbledit.ForeColor = Color.Black;
                        the = theame.blue;
                        lblFooter.ForeColor = lbltime.ForeColor = Color.Black;
                        lblheader.ForeColor = Color.Black;
                        information.Style.BackColor = Color.CornflowerBlue;
                        information.Style.BackColor2 = Color.MidnightBlue;
                        information.Style.TextColor = Color.White;
                        Footer.BackColor = Header.BackColor = Color.DeepSkyBlue;
                        mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.CornflowerBlue;
                        this.BackColor = Color.Blue;
                        txtID.BackColor =
                            txtName.BackColor =
                                txtFamily.BackColor =
                                    txtTel.BackColor = Color.White;

                        lang_fa.BackColor =
                            lang_en.BackColor =
                                PROGRMMER.BackColor =
                                    CURRENT_VER.BackColor =
                                        PASS_recovery.BackColor =
                                            PASS_change.BackColor =
                                                theGreen.BackColor =
                                                    theGold.BackColor =
                                                        theBlue.BackColor =
                                                            theBlack.BackColor =
                                                                UPDATE_k.BackColor =
                                                                    UPDATE_F.BackColor =
                                                                        DELETE_f.BackColor =
                                                                            UPDATE_M.BackColor =
                                                                                UPDATE_update.BackColor =
                                                                                    DELETE_M.BackColor =
                                                                                        DELETE_K.BackColor =
                                                                                            ADD.BackColor =
                                                                                                ADD_M.BackColor =
                                                                                                    ADD_K.BackColor =
                                                                                                        theFont.BackColor =
                                                                                                            ADD_F.BackColor
                                                                                                                =
                                                                                                                Color
                                                                                                                    .DeepSkyBlue;
                    }
                    break;
                case "theBlack":

                    the = theame.black;
                    lbledit.ForeColor = Color.White;
                    lblFooter.ForeColor = lbltime.ForeColor = Color.White;
                    lblheader.ForeColor = Color.White;
                    information.Style.BackColor = Color.Gray;
                    information.Style.BackColor2 = Color.Black;

                    Footer.BackColor = Header.BackColor = Color.DimGray;
                    mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.Gray;
                    this.BackColor = Color.Black;
                    txtID.BackColor =
                        txtName.BackColor =
                            txtFamily.BackColor =
                                txtTel.BackColor = Color.Wheat;
                    ADD.BackColor = Color.DimGray;

                    lang_fa.BackColor =
                        lang_en.BackColor =
                            PROGRMMER.BackColor =
                                CURRENT_VER.BackColor =
                                    PASS_recovery.BackColor =
                                        PASS_change.BackColor =
                                            theGreen.BackColor =
                                                theGold.BackColor =
                                                    theBlue.BackColor =
                                                        theBlack.BackColor =
                                                            UPDATE_k.BackColor =
                                                                UPDATE_F.BackColor =
                                                                    DELETE_f.BackColor =
                                                                        UPDATE_M.BackColor =
                                                                            UPDATE_update.BackColor =
                                                                                DELETE_M.BackColor =
                                                                                    DELETE_K.BackColor =
                                                                                        ADD_M.BackColor =
                                                                                            ADD_K.BackColor =
                                                                                                theFont.BackColor =
                                                                                                    ADD_F.BackColor =
                                                                                                        Color.SlateGray;

                    break;
                case "theGold":

                    the = theame.gold;
                    lbledit.ForeColor = Color.Black;
                    lblFooter.ForeColor = lbltime.ForeColor = Color.Black;
                    lblheader.ForeColor = Color.Black;
                    information.Style.BackColor = Color.OrangeRed;
                    information.Style.BackColor2 = Color.Goldenrod;
                    information.Style.TextColor = Color.White;
                    Footer.BackColor = Header.BackColor = Color.Yellow;
                    mnuMain.BackColor = dataGridViewX1.BackgroundColor = Color.Gold;
                    this.BackColor = Color.Khaki;
                    ADD.BackColor = Color.Yellow;
                    txtID.BackColor =
                        txtName.BackColor =
                            txtFamily.BackColor =
                                txtTel.BackColor = Color.Yellow;

                    lang_fa.BackColor =
                        lang_en.BackColor =
                            PROGRMMER.BackColor =
                                CURRENT_VER.BackColor =
                                    PASS_recovery.BackColor =
                                        PASS_change.BackColor =
                                            theGreen.BackColor =
                                                theGold.BackColor =
                                                    theBlue.BackColor =
                                                        theBlack.BackColor =
                                                            UPDATE_k.BackColor =
                                                                UPDATE_F.BackColor =
                                                                    DELETE_f.BackColor =
                                                                        UPDATE_M.BackColor =
                                                                            UPDATE_update.BackColor =
                                                                                DELETE_M.BackColor =
                                                                                    DELETE_K.BackColor =
                                                                                        ADD_M.BackColor =
                                                                                            ADD_K.BackColor =
                                                                                                theFont.BackColor =
                                                                                                    ADD_F.BackColor =
                                                                                                        Color.Orange;
                    break;
            }
        }

        private void menu_change(object sender, EventArgs e)
        {
            ToolStripMenuItem mnu = sender as ToolStripMenuItem;
            if (mnu.Name == "PASS_recovery")
            {
                Recovery_password ch = new Recovery_password();
                ch.ShowDialog();
            }
            else if (mnu.Name == "PASS_change")
            {
                ChangePass ch = new ChangePass();
                ch.ShowDialog(this);
            }
            else if (mnu.Name == "NEW_USER")
            {
                (new NewUser()).ShowDialog(this);
            }
            else if (mnu.Name == "ADD")
            {
                lblFooter.Text = "عملیات اضافه کردن";
            }
            else if (mnu.Name == "DELETE")
            {
                lblFooter.Text = "عملیات حذف کردن";
            }
            else if (mnu.Name == "UPDATE")
            {
                lblFooter.Text = "عملیات به روزرسانی کردن";
            }
        }



        private void timer_Tick(object sender, EventArgs e)
        {
            lbltime.Text =
                DateTime.Now.Hour +
                " : " + DateTime.Now.Minute +
                " : " + DateTime.Now.Second;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Theame = the.ToString();
            Properties.Settings.Default.Save();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_US(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Name;
            switch (name)
            {
                case "PROGRMMER":
                    About a = new About();
                    a.ShowDialog();
                    break;
                case "CURRENT_VER":
                    Ver v = new Ver();
                    v.ShowDialog();
                    break;
            }
        }

        private void Select_Lang(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi = sender as ToolStripMenuItem;
            if (tsmi.Name == "lang_en")
            {
                cinfo = new CultureInfo("en-US");
                Properties.Settings.Default.Lang = "en";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            else if (tsmi.Name == "lang_fa")
            {
                cinfo = new CultureInfo("fa-IR");
                Properties.Settings.Default.Lang = "fa";
                Properties.Settings.Default.Save();
                Application.Restart();
            }


        }

        private void theFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            mnuMain.Font = fontDialog1.Font;
        }

        private void PlayMusic(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic = sender as PictureBox;
            switch (pic.Name)
            {
                case "PicStop":
                    Player.Ctlcontrols.stop();
                    break;
                case "PicPlay":
                    Player.Ctlcontrols.play();
                    break;
                case "PicPause":
                    Player.Ctlcontrols.pause();
                    break;
            }
        }

        private void ADD_CLICK(object sender, EventArgs e)
        {
            lblFooter.Text = "عملیات اضافه کردن";

        }

        private void ADD_Enter(object sender, EventArgs e)
        {
            lblFooter.Text = "عملیات اضافه کردن";
        }

        private void ADD_Leave(object sender, EventArgs e)
        {
            lblFooter.Text = "";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            lblFooter.Text = "عملیات حذف کردن";
        }

        private void Del_Enter(object sender, EventArgs e)
        {
            lblFooter.Text = "عملیات حذف کردن";
        }

        private void Del_Leave(object sender, EventArgs e)
        {
            lblFooter.Text = "";
        }

        private void UPD_Click(object sender, EventArgs e)
        {
            lblFooter.Text = "عملیات به روزرسانی کردن";
        }

        private void UPD_Enter(object sender, EventArgs e)
        {
            lblFooter.Text = "عملیات به روزرسانی کردن";
        }

        private void UPD_Leave(object sender, EventArgs e)
        {
            lblFooter.Text = "";
        }

        private void Reporter_Click(object sender, EventArgs e)
        {
            (new Report()).ShowDialog(this);
        }

        private void Moshtari_Event(object sender, EventArgs e)
        {
            (new NewMoshtai()).ShowDialog();
        }

        private void Kala_Event(object sender, EventArgs e)
        {
            (new NewKala()).ShowDialog();
        }

        private void Provider_Event(object sender, EventArgs e)
        {
            (new NewProvider()).ShowDialog();
        }

        private void DeleteEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = new ToolStripMenuItem();
            tsmi = sender as ToolStripMenuItem;
            string name = tsmi.Name;
            switch (name)
            {
                case "DELETE_K":
                    (new EditK(false)).ShowDialog();
                    break;
                case "DELETE_M":
                    (new EditM(false)).ShowDialog();
                    break;
                case "DELETE_f":
                    (new EditP(false)).ShowDialog();
                    break;
            }
        }

        private void PicFactorKH_Click(object sender, EventArgs e)
        {
            (new FactorKh()).ShowDialog(this);
        }

        private void picFactorF_Click(object sender, EventArgs e)
        {
            (new FactorF()).ShowDialog(this);
        }

        private void picM_Click(object sender, EventArgs e)
        {
            //fisrtClick = true;
            DataAccess.Connect();
            d.cmdm.CommandText = "select * from moshtari";
            dap.SelectCommand = d.cmdm;
            dt.Clear();
            dap.Fill(dt);
            dataGridViewX1.DataSource = dt;
            if (Properties.Settings.Default.Lang == "en")
            {
                dataGridViewX1.Columns[0].HeaderText = "ID";
                dataGridViewX1.Columns[1].HeaderText = "NAME";
                dataGridViewX1.Columns[2].HeaderText = "LASTNAME";
                dataGridViewX1.Columns[3].HeaderText = "TEL";
            }
            else
            {
                dataGridViewX1.Columns[0].HeaderText = "شناسه";
                dataGridViewX1.Columns[1].HeaderText = "نام";
                dataGridViewX1.Columns[2].HeaderText = "نام خانوادگی";
                dataGridViewX1.Columns[3].HeaderText = "تلفن";

            }
            if (fisrtClick)
            {
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img.Width = 50;
                img.Image = Properties.Resources.smallCustomer;
                dataGridViewX1.Columns.Insert(4, img);
                fisrtClick = false;
            }
            DataAccess.Disconnect();
        }
        private void dataGridViewX1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dataGridViewX1.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
                txtFamily.Text = dataGridViewX1.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = dataGridViewX1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateM_Event(object sender, EventArgs e)
        {
            (new EditM(true)).ShowDialog(this);
        }

        private void UpdateK_Event(object sender, EventArgs e)
        {
            (new EditK(true)).ShowDialog(this);
        }

        private void UpdateP_Event(object sender, EventArgs e)
        {
            (new EditP(true)).ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void picM_MouseHover(object sender, EventArgs e)
        {
            pic = sender as PictureBox;
            string name = pic.Name;
            switch (name)
            {
                case "picM":
                    picM.Height += 30;
                    picM.Width += 30;
                    break;
                case "picFactorF":
                    picFactorF.Height += 30;
                    picFactorF.Width += 30;
                    break;
                case "PicFactorKH":
                    picReport.SendToBack();
                    PicFactorKH.Height += 30;
                    PicFactorKH.Width += 30;
                    break;
                case "picReporter":
                    picReporter.Height += 30;
                    picReporter.Width += 30;
                    break;
                case "picSubmit":
                    picSubmit.Height += 5;
                    picSubmit.Width += 5;
                    break;
                case "picReport":
                    picReport.Height += 20;
                    picReport.Width += 20;
                    break;
            }

        }

        private void picM_MouseLeave(object sender, EventArgs e)
        {
            pic = sender as PictureBox;
            string name = pic.Name;
            switch (name)
            {
                case "picM":
                    picM.Height -= 30;
                    picM.Width -= 30;
                    break;
                case "picFactorF":
                    picFactorF.Height -= 30;
                    picFactorF.Width -= 30;
                    break;
                case "PicFactorKH":
                    PicFactorKH.Height -= 30;
                    PicFactorKH.Width -= 30;
                    break;
                case "picReporter":
                    picReporter.Height -= 30;
                    picReporter.Width -= 30;
                    break;
                case "picSubmit":
                    picSubmit.Height -= 5;
                    picSubmit.Width -= 5;
                    break;
                case "picReport":
                    picReport.Height -= 20;
                    picReport.Width -= 20;
                    break;
            }
        }



        private void picedit_Click(object sender, EventArgs e)
        {
            if (st == -1)
            {
                picedit.Image = Properties.Resources.c;
                if (Properties.Settings.Default.Lang == "en")
                {
                    lbledit.Text = "Edit is Enabled";
                }
                else
                {
                    lbledit.Text = "ویرایش فعال است";
                }
                txtName.ReadOnly = false;
                txtFamily.ReadOnly = false;
                txtID.ReadOnly = false;
                txtTel.ReadOnly = false;

            }
            else if (st == 1)
            {
                picedit.Image = Properties.Resources.unc;
                if (Properties.Settings.Default.Lang == "en")
                {
                    lbledit.Text = "Edit is Disabled";
                }
                else
                {
                    lbledit.Text = "ویرایش غیر فعال است";
                }
                txtName.ReadOnly = true;
                txtFamily.ReadOnly = true;
                txtID.ReadOnly = true;
                txtTel.ReadOnly = true;
            }

            st *= -1;
        }

        private void picReporter_Click(object sender, EventArgs e)
        {
            (new Chart()).ShowDialog();
        }

        private void picSubmit_Click(object sender, EventArgs e)
        {
            DataAccess.Connect();
            var u =new Update();
            u.Moshtari(Convert.ToInt32(txtID.Text), txtName.Text,txtFamily.Text, txtTel.Text);
            MSG_CS.Msg m = new MSG_CS.Msg();
            m.Msge("ویرایش انجام شد","هشدار",MSG_CS.Msg.BtnType.OK,MSG_CS.Msg.IcnHeader.Error,Color.Gold);
            m.ShowDialog();
            DataAccess.Disconnect();
            
        }

        private void picReport_Click(object sender, EventArgs e)
        {
            (new Report()).ShowDialog(this);
        }

        private void picReport_Click_1(object sender, EventArgs e)
        {
            (new Report()).ShowDialog(this);
        }

        private void picREport_Click_2(object sender, EventArgs e)
        {
            (new Report()).ShowDialog(this);
        }
    }
}
