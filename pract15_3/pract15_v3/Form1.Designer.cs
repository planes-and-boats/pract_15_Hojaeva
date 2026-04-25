namespace pract15_v3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdd = new Button();
            tbX = new TextBox();
            tbY = new TextBox();
            tbZ = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            label2 = new Label();
            buttonSum = new Button();
            buttonSub = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            label3 = new Label();
            buttonMultiply = new Button();
            buttonKos = new Button();
            buttonMaxL = new Button();
            buttonL = new Button();
            label4 = new Label();
            listBox2 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(35, 215);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // tbX
            // 
            tbX.Location = new Point(35, 78);
            tbX.Name = "tbX";
            tbX.PlaceholderText = "Введите X";
            tbX.Size = new Size(100, 23);
            tbX.TabIndex = 1;
            // 
            // tbY
            // 
            tbY.Location = new Point(35, 126);
            tbY.Name = "tbY";
            tbY.PlaceholderText = "Введите Y";
            tbY.Size = new Size(100, 23);
            tbY.TabIndex = 2;
            // 
            // tbZ
            // 
            tbZ.Location = new Point(35, 169);
            tbZ.Name = "tbZ";
            tbZ.PlaceholderText = "Введите Z";
            tbZ.Size = new Size(100, 23);
            tbZ.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Введите данные:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(tbZ);
            groupBox1.Controls.Add(tbX);
            groupBox1.Controls.Add(tbY);
            groupBox1.Location = new Point(26, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 281);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление вектора";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(251, 78);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 124);
            listBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 50);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 7;
            label2.Text = "Список векторов";
            // 
            // buttonSum
            // 
            buttonSum.Location = new Point(251, 337);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(75, 23);
            buttonSum.TabIndex = 8;
            buttonSum.Text = "Сумма";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(251, 390);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(75, 23);
            buttonSub.TabIndex = 9;
            buttonSub.Text = "Разность";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(251, 287);
            tb1.Name = "tb1";
            tb1.PlaceholderText = "Введите номер";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 10;
            // 
            // tb2
            // 
            tb2.Location = new Point(378, 287);
            tb2.Name = "tb2";
            tb2.PlaceholderText = "Введите номер";
            tb2.Size = new Size(100, 23);
            tb2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 238);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 12;
            label3.Text = "Введите номера векторов для\r\nполучения нового вектора:";
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(386, 337);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(92, 41);
            buttonMultiply.TabIndex = 13;
            buttonMultiply.Text = "Получить произведение";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonKos
            // 
            buttonKos.Location = new Point(386, 390);
            buttonKos.Name = "buttonKos";
            buttonKos.Size = new Size(92, 23);
            buttonKos.TabIndex = 14;
            buttonKos.Text = "Косинус угла";
            buttonKos.UseVisualStyleBackColor = true;
            buttonKos.Click += buttonKos_Click;
            // 
            // buttonMaxL
            // 
            buttonMaxL.Location = new Point(518, 370);
            buttonMaxL.Name = "buttonMaxL";
            buttonMaxL.Size = new Size(99, 43);
            buttonMaxL.TabIndex = 15;
            buttonMaxL.Text = "Самый длиный вектор";
            buttonMaxL.UseVisualStyleBackColor = true;
            buttonMaxL.Click += buttonMaxL_Click;
            // 
            // buttonL
            // 
            buttonL.Location = new Point(404, 111);
            buttonL.Name = "buttonL";
            buttonL.Size = new Size(99, 43);
            buttonL.TabIndex = 16;
            buttonL.Text = "Длинны векторов";
            buttonL.UseVisualStyleBackColor = true;
            buttonL.Click += buttonL_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 50);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 18;
            label4.Text = "Список длин векторов";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(519, 78);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(132, 124);
            listBox2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 450);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(buttonL);
            Controls.Add(buttonMaxL);
            Controls.Add(buttonKos);
            Controls.Add(buttonMultiply);
            Controls.Add(label3);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(buttonSub);
            Controls.Add(buttonSum);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Вектор";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox tbX;
        private TextBox tbY;
        private TextBox tbZ;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label2;
        private Button buttonSum;
        private Button buttonSub;
        private TextBox tb1;
        private TextBox tb2;
        private Label label3;
        private Button buttonMultiply;
        private Button buttonKos;
        private Button buttonMaxL;
        private Button buttonL;
        private Label label4;
        private ListBox listBox2;
    }
}
