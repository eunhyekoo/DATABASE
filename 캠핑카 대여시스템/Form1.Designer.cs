namespace WindowsFormsApplication1



{



    partial class Form1



    {



        /// <summary>



        /// 필수 디자이너 변수입니다.



        /// </summary>



        private System.ComponentModel.IContainer components = null;







        /// <summary>



        /// 사용 중인 모든 리소스를 정리합니다.



        /// </summary>



        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>



        protected override void Dispose(bool disposing)



        {



            if (disposing && (components != null))



            {



                components.Dispose();



            }



            base.Dispose(disposing);



        }







        #region Windows Form 디자이너에서 생성한 코드







        /// <summary>



        /// 디자이너 지원에 필요한 메서드입니다.



        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.



        /// </summary>



        private void InitializeComponent()



        {
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxId = new System.Windows.Forms.TextBox();
            this.txtBoxPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.selectTable = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1377, 472);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "반납";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(117, 106);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 58);
            this.button11.TabIndex = 0;
            this.button11.Text = "user Login";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxId
            // 
            this.txtboxId.Location = new System.Drawing.Point(64, 26);
            this.txtboxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxId.Name = "txtboxId";
            this.txtboxId.Size = new System.Drawing.Size(129, 25);
            this.txtboxId.TabIndex = 1;
            // 
            // txtBoxPw
            // 
            this.txtBoxPw.Location = new System.Drawing.Point(64, 59);
            this.txtBoxPw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPw.Name = "txtBoxPw";
            this.txtBoxPw.PasswordChar = '*';
            this.txtBoxPw.Size = new System.Drawing.Size(129, 25);
            this.txtBoxPw.TabIndex = 2;
            this.txtBoxPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPw_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "pw";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(219, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(947, 274);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.Gray;
            this.dataGridView2.Location = new System.Drawing.Point(219, 368);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(947, 262);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.Location = new System.Drawing.Point(219, 682);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(947, 115);
            this.textBox1.TabIndex = 6;
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(1329, 35);
            this.txt0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(157, 25);
            this.txt0.TabIndex = 7;
            this.txt0.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1185, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 8;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1186, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 8;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1186, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 8;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1186, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 8;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(1186, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 8;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(1186, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 8;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(1186, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 8;
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(1185, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 8;
            this.label10.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(1329, 76);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(157, 25);
            this.txt1.TabIndex = 7;
            this.txt1.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(1329, 125);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(157, 25);
            this.txt2.TabIndex = 7;
            this.txt2.Visible = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(1329, 165);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(157, 25);
            this.txt3.TabIndex = 7;
            this.txt3.Visible = false;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(1329, 218);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(157, 25);
            this.txt4.TabIndex = 7;
            this.txt4.Visible = false;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(1329, 268);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(157, 25);
            this.txt5.TabIndex = 7;
            this.txt5.Visible = false;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(1329, 312);
            this.txt6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(157, 25);
            this.txt6.TabIndex = 7;
            this.txt6.Visible = false;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(1329, 358);
            this.txt7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(157, 25);
            this.txt7.TabIndex = 7;
            this.txt7.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1195, 412);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1290, 412);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1377, 412);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 52);
            this.button4.TabIndex = 9;
            this.button4.Text = "수정";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1197, 472);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "확인";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1290, 472);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "대여";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 653);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "SQL명령";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "목록";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "확인";
            // 
            // selectTable
            // 
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Location = new System.Drawing.Point(14, 204);
            this.selectTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(193, 23);
            this.selectTable.TabIndex = 10;
            this.selectTable.SelectedIndexChanged += new System.EventHandler(this.selectTable_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "테이블 선택";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1197, 530);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 52);
            this.button7.TabIndex = 15;
            this.button7.Text = "초기화";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1568, 856);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.selectTable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPw);
            this.Controls.Add(this.txtboxId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "캠핑카 대여 시스템";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }







        #endregion







        private System.Windows.Forms.Button button1;



        private System.Windows.Forms.Button button11;



        private System.Windows.Forms.TextBox txtboxId;



        private System.Windows.Forms.TextBox txtBoxPw;



        private System.Windows.Forms.Label label1;



        private System.Windows.Forms.Label label2;



        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox textBox1;



        private System.Windows.Forms.TextBox txt0;



        private System.Windows.Forms.Label label3;



        private System.Windows.Forms.Label label4;



        private System.Windows.Forms.Label label5;



        private System.Windows.Forms.Label label6;



        private System.Windows.Forms.Label label7;



        private System.Windows.Forms.Label label8;



        private System.Windows.Forms.Label label9;



        private System.Windows.Forms.Label label10;



        private System.Windows.Forms.TextBox txt1;



        private System.Windows.Forms.TextBox txt2;



        private System.Windows.Forms.TextBox txt3;



        private System.Windows.Forms.TextBox txt4;



        private System.Windows.Forms.TextBox txt5;



        private System.Windows.Forms.TextBox txt6;



        private System.Windows.Forms.TextBox txt7;



        private System.Windows.Forms.Button button2;



        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button8;

        private System.Windows.Forms.Button button4;



        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.ComboBox selectTable;



        private System.Windows.Forms.Label label12;

        internal System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button7;
    }



}