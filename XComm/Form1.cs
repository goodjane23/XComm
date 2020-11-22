using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using XComm.Extentions;

namespace XComm
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();            
            
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            commentTxt.Clear();
            if (loginTxt.IsNotEmpty())
            {
                commentTxt.Text += loginTxt.Text + ", ";
            };
            if (authorizationCbx.IsNotEmpty())
            {
                commentTxt.Text += label1.Text + " " + authorizationCbx.Text + ", ";
            };
            if (losChk.IsNotEmpty())
            {
                commentTxt.Text += $"{losChk.Text}, ";
            }
            if (breaksChk.IsNotEmpty())
            {
                commentTxt.Text += breaksChk.Text.ToLower() + ", ";
            };
            if (limitsChk.IsNotEmpty())
            {
                commentTxt.Text += "в логах " + limitsChk.Text.ToLower() + ", ";
            };
            if (portCbx.IsNotEmpty())
            {
                commentTxt.Text += label2.Text.ToLower() + " " + portCbx.Text.ToLower() + ", ";
            };

            if (errorLineCbx.IsNotEmpty())
            {
                if (errorsLineLbl.Text == "Линия")
                {
                    commentTxt.Text += errorsLineLbl.Text + " " + errorLineCbx.Text + ", ";
                }

                if (errorsLineLbl.Text == "Ошибки" && errorLineCbx.SelectedIndex == 0)
                {
                    if (upChk.Checked)
                    {
                        commentTxt.Text += errorsLineLbl.Text + " " + errorLineCbx.Text + " , растут, ";
                    }
                    else commentTxt.Text += errorsLineLbl.Text + " " + errorLineCbx.Text + " , не растут, ";
                }
                if (errorsLineLbl.Text == "Ошибки" && errorLineCbx.SelectedIndex == 1)
                {
                    commentTxt.Text += errorsLineLbl.Text + " " + errorLineCbx.Text + ", ";
                }
            }

            if (dataCbx.IsNotEmpty()) 
            {
                commentTxt.Text += label4.Text.ToLower() + " " + dataCbx.Text.ToLower() + ", ";
            };
            if (mongoErrorCbx.IsNotEmpty())
            {
                commentTxt.Text += label8.Text.ToLower() + " " + mongoErrorCbx.Text.ToLower() + ", ";
            };
            commentTxt.Text += "\r\n";
            if (nameTxt.IsNotEmpty()) 
            {
                commentTxt.Text +=  " " + nameTxt.Text + ", ";
            };
            if (lsTxt.IsNotEmpty()) 
            {
                commentTxt.Text += lsTxt.Text + ", ";
            };
            if (phoneTxt.IsNotEmpty())
            {
                commentTxt.Text += " " + phoneTxt.Text + ", ";
            };
            commentTxt.Text += "\r\n";
            if (macTxt.IsNotEmpty())
            {
                commentTxt.Text += macTxt.Text.ToUpper() + ", ";
            };

            if (portParamsTxt.IsNotEmpty())
            {
                commentTxt.Text += " " + portParamsTxt.Text.ToLower() + " ";
            }

            if (lineParamsTxt.IsNotEmpty())
            {
                commentTxt.Text += " " + lineParamsTxt.Text.ToLower() + " ";
            }
            if (equipmentCbx.IsNotEmpty())
            {
                commentTxt.Text += $"{equipmentlbl.Text.ToLower()} {equipmentCbx.Text}.";
            }
            if (rdxTxt.IsNotEmpty())
            {
                commentTxt.Text += rdxTxt.Text;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            authorizationCbx.SelectedIndex = -1;
            mongoErrorCbx.SelectedIndex = -1;
            dataCbx.SelectedIndex = -1;
            errorLineCbx.SelectedIndex = -1;
            portCbx.SelectedIndex = -1;
            limitsChk.Checked = false;
            breaksChk.Checked = false;
            upChk.Checked = false;
            losChk.Checked = false;
            macTxt.Clear();
            phoneTxt.Clear();
            loginTxt.Clear();
            lsTxt.Clear();
            nameTxt.Clear();
            lineParamsTxt.Clear();
            portParamsTxt.Clear();
            commentTxt.Clear();
            rdxTxt.Clear();
            equipmentCbx.SelectedIndex = -1;
        }


        private void radioBtn_Selected_Change(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            switch (radioButton.Name)
            {
                case "xdslRbtn":
                    upChk.Visible = false;
                    errorsLineLbl.Text = "Линия";
                    label2.Text = "Порт";
                    portCbx.Items.Clear();
                    portCbx.Items.AddRange(new string[] { "активен", "не активен", "не доступен для диагностики" });
                    errorLineCbx.Items.Clear();
                    errorLineCbx.Items.AddRange(new string[] { "норма", "не измеряется", "недоступна для измерения" });                    
                    errorsLineLbl.Visible = true;
                    errorLineCbx.Visible = true;
                    losChk.Visible = false;
                    break;
                case "fttxRbtn":
                    errorsLineLbl.Text = "Ошибки";
                    label2.Text = "Порт";
                    portCbx.Items.Clear();
                    portCbx.Items.AddRange(new string[] { "активен", "не активен", "не доступен для диагностики" });
                    errorLineCbx.Items.Clear();
                    errorLineCbx.Items.AddRange(new string[] {"отсутсвуют", "есть" });
                    errorsLineLbl.Visible = true;
                    errorLineCbx.Visible = true;
                    losChk.Visible = false;
                    break;
                case "xponRbtn":
                    errorsLineLbl.Visible = false;
                    errorLineCbx.Visible = false;
                    upChk.Visible = false;
                    losChk.Visible = true;
                    label2.Text = "ONT";
                    portCbx.Items.Clear();
                    portCbx.Items.AddRange(new string[] { "активно", "не активно" });
                    break;
            }
            xdslPanel.Visible = xdslRbtn.Checked;
            xponPanel.Visible = xponRbtn.Checked;

        }

        private void errorLineCbx_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((string)errorLineCbx.SelectedItem == "есть")
            {
                upChk.Visible = true;
            }
            else upChk.Visible = false;
        }

        private void addToDocBtn_Click(object sender, EventArgs e)
        {

            string fileName;
            DateTime date = new DateTime();
            fileName = date.ToLongDateString() + ".txt";

            byte[] result = new UTF8Encoding().GetBytes(commentTxt.Text);
            // проверка создания документа
            using (FileStream fs = File.Open(fileName +".txt", FileMode.Append))
            {
                fs.Write(result, 0, result.Length);
                
            }           

        }

    }
}
