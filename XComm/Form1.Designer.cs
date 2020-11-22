namespace XComm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateBtn = new System.Windows.Forms.Button();
            this.limitsChk = new System.Windows.Forms.CheckBox();
            this.breaksChk = new System.Windows.Forms.CheckBox();
            this.macTxt = new System.Windows.Forms.TextBox();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.lsTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mongoErrorCbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataCbx = new System.Windows.Forms.ComboBox();
            this.upChk = new System.Windows.Forms.CheckBox();
            this.errorLineCbx = new System.Windows.Forms.ComboBox();
            this.portCbx = new System.Windows.Forms.ComboBox();
            this.authorizationCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorsLineLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fttxRbtn = new System.Windows.Forms.RadioButton();
            this.xdslRbtn = new System.Windows.Forms.RadioButton();
            this.xponRbtn = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.portParamsLbl = new System.Windows.Forms.Label();
            this.lineParamsLbl = new System.Windows.Forms.Label();
            this.portParamsTxt = new System.Windows.Forms.TextBox();
            this.lineParamsTxt = new System.Windows.Forms.TextBox();
            this.xdslPanel = new System.Windows.Forms.Panel();
            this.losChk = new System.Windows.Forms.CheckBox();
            this.equipmentlbl = new System.Windows.Forms.Label();
            this.equipmentCbx = new System.Windows.Forms.ComboBox();
            this.notifyBtn = new System.Windows.Forms.Button();
            this.addToDocBtn = new System.Windows.Forms.Button();
            this.xponPanel = new System.Windows.Forms.Panel();
            this.rdxTxt = new System.Windows.Forms.TextBox();
            this.rdxLbl = new System.Windows.Forms.Label();
            this.xdslPanel.SuspendLayout();
            this.xponPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(394, 569);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 28);
            this.updateBtn.TabIndex = 53;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // limitsChk
            // 
            this.limitsChk.AutoSize = true;
            this.limitsChk.Location = new System.Drawing.Point(286, 58);
            this.limitsChk.Margin = new System.Windows.Forms.Padding(4);
            this.limitsChk.Name = "limitsChk";
            this.limitsChk.Size = new System.Drawing.Size(82, 21);
            this.limitsChk.TabIndex = 52;
            this.limitsChk.Text = "Лимиты";
            this.limitsChk.UseVisualStyleBackColor = true;
            // 
            // breaksChk
            // 
            this.breaksChk.AutoSize = true;
            this.breaksChk.Location = new System.Drawing.Point(202, 57);
            this.breaksChk.Margin = new System.Windows.Forms.Padding(4);
            this.breaksChk.Name = "breaksChk";
            this.breaksChk.Size = new System.Drawing.Size(76, 21);
            this.breaksChk.TabIndex = 51;
            this.breaksChk.Text = "Рвется";
            this.breaksChk.UseVisualStyleBackColor = true;
            // 
            // macTxt
            // 
            this.macTxt.Location = new System.Drawing.Point(687, 280);
            this.macTxt.Margin = new System.Windows.Forms.Padding(4);
            this.macTxt.Name = "macTxt";
            this.macTxt.Size = new System.Drawing.Size(181, 22);
            this.macTxt.TabIndex = 50;
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(202, 86);
            this.loginTxt.Margin = new System.Windows.Forms.Padding(4);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(166, 22);
            this.loginTxt.TabIndex = 48;
            // 
            // commentTxt
            // 
            this.commentTxt.Location = new System.Drawing.Point(99, 356);
            this.commentTxt.Margin = new System.Windows.Forms.Padding(4);
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(883, 190);
            this.commentTxt.TabIndex = 47;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(203, 326);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(166, 22);
            this.phoneTxt.TabIndex = 42;
            // 
            // lsTxt
            // 
            this.lsTxt.Location = new System.Drawing.Point(203, 292);
            this.lsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lsTxt.Name = "lsTxt";
            this.lsTxt.Size = new System.Drawing.Size(166, 22);
            this.lsTxt.TabIndex = 41;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(203, 256);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(166, 22);
            this.nameTxt.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(556, 283);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 49;
            this.label10.Text = "МAC";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(268, 569);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(100, 28);
            this.okBtn.TabIndex = 45;
            this.okBtn.Text = "Ок";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Логин";
            // 
            // mongoErrorCbx
            // 
            this.mongoErrorCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mongoErrorCbx.FormattingEnabled = true;
            this.mongoErrorCbx.Items.AddRange(new object[] {
            "есть",
            "нет",
            "незначительны"});
            this.mongoErrorCbx.Location = new System.Drawing.Point(687, 248);
            this.mongoErrorCbx.Margin = new System.Windows.Forms.Padding(4);
            this.mongoErrorCbx.Name = "mongoErrorCbx";
            this.mongoErrorCbx.Size = new System.Drawing.Size(181, 24);
            this.mongoErrorCbx.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(556, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ошибки по монго";
            // 
            // dataCbx
            // 
            this.dataCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataCbx.FormattingEnabled = true;
            this.dataCbx.Items.AddRange(new object[] {
            "соответсвуют",
            "не соответсвуют"});
            this.dataCbx.Location = new System.Drawing.Point(203, 197);
            this.dataCbx.Margin = new System.Windows.Forms.Padding(4);
            this.dataCbx.Name = "dataCbx";
            this.dataCbx.Size = new System.Drawing.Size(166, 24);
            this.dataCbx.TabIndex = 38;
            // 
            // upChk
            // 
            this.upChk.AutoSize = true;
            this.upChk.Location = new System.Drawing.Point(377, 157);
            this.upChk.Margin = new System.Windows.Forms.Padding(4);
            this.upChk.Name = "upChk";
            this.upChk.Size = new System.Drawing.Size(75, 21);
            this.upChk.TabIndex = 37;
            this.upChk.Text = "Растут";
            this.upChk.UseVisualStyleBackColor = true;
            this.upChk.Visible = false;
            // 
            // errorLineCbx
            // 
            this.errorLineCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorLineCbx.FormattingEnabled = true;
            this.errorLineCbx.Items.AddRange(new object[] {
            "есть",
            "отсутствуют"});
            this.errorLineCbx.Location = new System.Drawing.Point(203, 155);
            this.errorLineCbx.Margin = new System.Windows.Forms.Padding(4);
            this.errorLineCbx.Name = "errorLineCbx";
            this.errorLineCbx.Size = new System.Drawing.Size(166, 24);
            this.errorLineCbx.TabIndex = 36;
            this.errorLineCbx.SelectedValueChanged += new System.EventHandler(this.errorLineCbx_SelectedValueChanged);
            // 
            // portCbx
            // 
            this.portCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portCbx.FormattingEnabled = true;
            this.portCbx.Items.AddRange(new object[] {
            "активен",
            "не активен",
            "недоступен для измерения"});
            this.portCbx.Location = new System.Drawing.Point(202, 121);
            this.portCbx.Margin = new System.Windows.Forms.Padding(4);
            this.portCbx.Name = "portCbx";
            this.portCbx.Size = new System.Drawing.Size(166, 24);
            this.portCbx.TabIndex = 35;
            // 
            // authorizationCbx
            // 
            this.authorizationCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorizationCbx.FormattingEnabled = true;
            this.authorizationCbx.Items.AddRange(new object[] {
            "есть",
            "отсутсвует"});
            this.authorizationCbx.Location = new System.Drawing.Point(202, 20);
            this.authorizationCbx.Margin = new System.Windows.Forms.Padding(4);
            this.authorizationCbx.Name = "authorizationCbx";
            this.authorizationCbx.Size = new System.Drawing.Size(166, 24);
            this.authorizationCbx.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Л/C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Тех. данные";
            // 
            // errorsLineLbl
            // 
            this.errorsLineLbl.AutoSize = true;
            this.errorsLineLbl.Location = new System.Drawing.Point(99, 158);
            this.errorsLineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorsLineLbl.Name = "errorsLineLbl";
            this.errorsLineLbl.Size = new System.Drawing.Size(61, 17);
            this.errorsLineLbl.TabIndex = 29;
            this.errorsLineLbl.Text = "Ошибки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Порт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Авторизация";
            // 
            // fttxRbtn
            // 
            this.fttxRbtn.AutoSize = true;
            this.fttxRbtn.Location = new System.Drawing.Point(16, 15);
            this.fttxRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.fttxRbtn.Name = "fttxRbtn";
            this.fttxRbtn.Size = new System.Drawing.Size(61, 21);
            this.fttxRbtn.TabIndex = 54;
            this.fttxRbtn.Text = "FTTx";
            this.fttxRbtn.UseVisualStyleBackColor = true;
            this.fttxRbtn.CheckedChanged += new System.EventHandler(this.radioBtn_Selected_Change);
            // 
            // xdslRbtn
            // 
            this.xdslRbtn.AutoSize = true;
            this.xdslRbtn.Location = new System.Drawing.Point(15, 43);
            this.xdslRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.xdslRbtn.Name = "xdslRbtn";
            this.xdslRbtn.Size = new System.Drawing.Size(62, 21);
            this.xdslRbtn.TabIndex = 55;
            this.xdslRbtn.Text = "xDSL";
            this.xdslRbtn.UseVisualStyleBackColor = true;
            this.xdslRbtn.CheckedChanged += new System.EventHandler(this.radioBtn_Selected_Change);
            // 
            // xponRbtn
            // 
            this.xponRbtn.AutoSize = true;
            this.xponRbtn.Location = new System.Drawing.Point(15, 71);
            this.xponRbtn.Margin = new System.Windows.Forms.Padding(4);
            this.xponRbtn.Name = "xponRbtn";
            this.xponRbtn.Size = new System.Drawing.Size(65, 21);
            this.xponRbtn.TabIndex = 56;
            this.xponRbtn.Text = "xPON";
            this.xponRbtn.UseVisualStyleBackColor = true;
            this.xponRbtn.CheckedChanged += new System.EventHandler(this.radioBtn_Selected_Change);
            // 
            // portParamsLbl
            // 
            this.portParamsLbl.AutoSize = true;
            this.portParamsLbl.Location = new System.Drawing.Point(11, 12);
            this.portParamsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portParamsLbl.Name = "portParamsLbl";
            this.portParamsLbl.Size = new System.Drawing.Size(200, 17);
            this.portParamsLbl.TabIndex = 59;
            this.portParamsLbl.Text = "Запишите параметры порта:";
            // 
            // lineParamsLbl
            // 
            this.lineParamsLbl.AutoSize = true;
            this.lineParamsLbl.Location = new System.Drawing.Point(11, 79);
            this.lineParamsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineParamsLbl.Name = "lineParamsLbl";
            this.lineParamsLbl.Size = new System.Drawing.Size(205, 17);
            this.lineParamsLbl.TabIndex = 60;
            this.lineParamsLbl.Text = "Запишите  параметры линии:";
            // 
            // portParamsTxt
            // 
            this.portParamsTxt.Location = new System.Drawing.Point(15, 42);
            this.portParamsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.portParamsTxt.Name = "portParamsTxt";
            this.portParamsTxt.Size = new System.Drawing.Size(292, 22);
            this.portParamsTxt.TabIndex = 61;
            // 
            // lineParamsTxt
            // 
            this.lineParamsTxt.Location = new System.Drawing.Point(15, 106);
            this.lineParamsTxt.Margin = new System.Windows.Forms.Padding(4);
            this.lineParamsTxt.Name = "lineParamsTxt";
            this.lineParamsTxt.Size = new System.Drawing.Size(292, 22);
            this.lineParamsTxt.TabIndex = 62;
            // 
            // xdslPanel
            // 
            this.xdslPanel.Controls.Add(this.portParamsLbl);
            this.xdslPanel.Controls.Add(this.lineParamsTxt);
            this.xdslPanel.Controls.Add(this.lineParamsLbl);
            this.xdslPanel.Controls.Add(this.portParamsTxt);
            this.xdslPanel.Location = new System.Drawing.Point(540, 29);
            this.xdslPanel.Margin = new System.Windows.Forms.Padding(4);
            this.xdslPanel.Name = "xdslPanel";
            this.xdslPanel.Size = new System.Drawing.Size(356, 154);
            this.xdslPanel.TabIndex = 63;
            this.xdslPanel.Visible = false;
            // 
            // losChk
            // 
            this.losChk.AutoSize = true;
            this.losChk.Location = new System.Drawing.Point(375, 19);
            this.losChk.Name = "losChk";
            this.losChk.Size = new System.Drawing.Size(159, 21);
            this.losChk.TabIndex = 64;
            this.losChk.Text = "LOS горит красным";
            this.losChk.UseVisualStyleBackColor = true;
            this.losChk.Visible = false;
            // 
            // equipmentlbl
            // 
            this.equipmentlbl.AutoSize = true;
            this.equipmentlbl.Location = new System.Drawing.Point(556, 315);
            this.equipmentlbl.Name = "equipmentlbl";
            this.equipmentlbl.Size = new System.Drawing.Size(105, 17);
            this.equipmentlbl.TabIndex = 65;
            this.equipmentlbl.Text = "Обоурдование";
            // 
            // equipmentCbx
            // 
            this.equipmentCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentCbx.FormattingEnabled = true;
            this.equipmentCbx.Items.AddRange(new object[] {
            "аренда",
            "собственность",
            "гарантия"});
            this.equipmentCbx.Location = new System.Drawing.Point(687, 312);
            this.equipmentCbx.Name = "equipmentCbx";
            this.equipmentCbx.Size = new System.Drawing.Size(181, 24);
            this.equipmentCbx.TabIndex = 66;
            // 
            // notifyBtn
            // 
            this.notifyBtn.Location = new System.Drawing.Point(516, 569);
            this.notifyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.notifyBtn.Name = "notifyBtn";
            this.notifyBtn.Size = new System.Drawing.Size(129, 28);
            this.notifyBtn.TabIndex = 67;
            this.notifyBtn.Text = "В напоминание";
            this.notifyBtn.UseVisualStyleBackColor = true;
            // 
            // addToDocBtn
            // 
            this.addToDocBtn.Location = new System.Drawing.Point(662, 569);
            this.addToDocBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addToDocBtn.Name = "addToDocBtn";
            this.addToDocBtn.Size = new System.Drawing.Size(100, 28);
            this.addToDocBtn.TabIndex = 68;
            this.addToDocBtn.Text = "Записать";
            this.addToDocBtn.UseVisualStyleBackColor = true;
            this.addToDocBtn.Click += new System.EventHandler(this.addToDocBtn_Click);
            // 
            // xponPanel
            // 
            this.xponPanel.Controls.Add(this.rdxTxt);
            this.xponPanel.Controls.Add(this.rdxLbl);
            this.xponPanel.Location = new System.Drawing.Point(540, 32);
            this.xponPanel.Name = "xponPanel";
            this.xponPanel.Size = new System.Drawing.Size(290, 109);
            this.xponPanel.TabIndex = 69;
            // 
            // rdxTxt
            // 
            this.rdxTxt.Location = new System.Drawing.Point(14, 33);
            this.rdxTxt.Name = "rdxTxt";
            this.rdxTxt.Size = new System.Drawing.Size(236, 22);
            this.rdxTxt.TabIndex = 1;
            // 
            // rdxLbl
            // 
            this.rdxLbl.AutoSize = true;
            this.rdxLbl.Location = new System.Drawing.Point(11, 5);
            this.rdxLbl.Name = "rdxLbl";
            this.rdxLbl.Size = new System.Drawing.Size(77, 17);
            this.rdxLbl.TabIndex = 0;
            this.rdxLbl.Text = "Затухание";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1021, 641);
            this.Controls.Add(this.xponPanel);
            this.Controls.Add(this.addToDocBtn);
            this.Controls.Add(this.notifyBtn);
            this.Controls.Add(this.equipmentCbx);
            this.Controls.Add(this.equipmentlbl);
            this.Controls.Add(this.losChk);
            this.Controls.Add(this.xdslPanel);
            this.Controls.Add(this.xponRbtn);
            this.Controls.Add(this.xdslRbtn);
            this.Controls.Add(this.fttxRbtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.limitsChk);
            this.Controls.Add(this.breaksChk);
            this.Controls.Add(this.macTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.lsTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mongoErrorCbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataCbx);
            this.Controls.Add(this.upChk);
            this.Controls.Add(this.errorLineCbx);
            this.Controls.Add(this.portCbx);
            this.Controls.Add(this.authorizationCbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorsLineLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Xcomm";
            this.xdslPanel.ResumeLayout(false);
            this.xdslPanel.PerformLayout();
            this.xponPanel.ResumeLayout(false);
            this.xponPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.CheckBox limitsChk;
        private System.Windows.Forms.CheckBox breaksChk;
        private System.Windows.Forms.TextBox macTxt;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox lsTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox mongoErrorCbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dataCbx;
        private System.Windows.Forms.CheckBox upChk;
        private System.Windows.Forms.ComboBox errorLineCbx;
        private System.Windows.Forms.ComboBox portCbx;
        private System.Windows.Forms.ComboBox authorizationCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errorsLineLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton fttxRbtn;
        private System.Windows.Forms.RadioButton xdslRbtn;
        private System.Windows.Forms.RadioButton xponRbtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label portParamsLbl;
        private System.Windows.Forms.Label lineParamsLbl;
        private System.Windows.Forms.TextBox portParamsTxt;
        private System.Windows.Forms.TextBox lineParamsTxt;
        private System.Windows.Forms.Panel xdslPanel;
        private System.Windows.Forms.CheckBox losChk;
        private System.Windows.Forms.Label equipmentlbl;
        private System.Windows.Forms.ComboBox equipmentCbx;
        private System.Windows.Forms.Button notifyBtn;
        private System.Windows.Forms.Button addToDocBtn;
        private System.Windows.Forms.Panel xponPanel;
        private System.Windows.Forms.TextBox rdxTxt;
        private System.Windows.Forms.Label rdxLbl;
    }
}

