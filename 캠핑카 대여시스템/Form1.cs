using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;



using System.Drawing;



using System.Linq;



using System.Text;



using System.Windows.Forms;



using System.Data.OleDb;



using System.Collections;









namespace WindowsFormsApplication1



{



    public partial class Form1 : Form



    {



        OleDbConnection conn;



        string connectionString;

        String users = "";





        TextBox[] textBoxes;



        Label[] labels;



        List<Type> types = new List<Type>();

        int count;





        public Form1()



        {



            InitializeComponent();



            dataGridView1.Rows.Clear();







            textBoxes = new TextBox[] { txt0, txt1, txt2, txt3, txt4, txt5, txt6, txt7 };



            labels = new Label[] { label3, label4, label5, label6, label7, label8, label9, label10 };







        }

        //login 버튼

        private void button1_Click(object sender, EventArgs e)



        {



            dataGridView1.Rows.Clear(); // GridView와 Combobox의 내용을 모두 지우기



            selectTable.Items.Clear();





            if (conn != null)   // 기존에 연결되어있는 DB가 있으면 연결 해제



            {



                conn.Close();



            }







            connectionString = "Provider=OraOLEDB.Oracle;Password=" + txtBoxPw.Text + ";User ID=" + txtboxId.Text;//oracle 서버 연결







            //연결 스트링에 대한 정보 



            //Oracle - MSDAORA 







            conn = new OleDbConnection(connectionString);



            conn.Open(); //데이터베이스 연결





            //SELECT table_name, column_name



            OleDbCommand cmd = new OleDbCommand();



            cmd.CommandText = "SELECT table_name FROM tabs  "; // 테이블 불러오기





            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



            cmd.Connection = conn;



            OleDbDataReader read = cmd.ExecuteReader();

            count = read.FieldCount; // 해당 테이블의 column 수를 지정



            while (read.Read())



            {



                selectTable.Items.Add(read.GetValue(0));



            } // Combobox에 테이블이름 Item으로 추가







            selectTable.SelectedIndex = 0; // 첫번째 테이블 선택







            updatedb();



        }

        //user로그인

        private void button11_Click(object sender, EventArgs e)



        {



            dataGridView1.Rows.Clear(); // GridView와 Combobox의 내용을 모두 지우기



            selectTable.Items.Clear();
            


            if (conn != null)   // 기존에 연결되어있는 DB가 있으면 연결 해제



            {



                conn.Close();



            }





            connectionString = "Provider=OraOLEDB.Oracle;Password=" + txtBoxPw.Text + ";User ID=" + txtboxId.Text;//oracle 서버 연결



            //연결 스트링에 대한 정보 

            //Oracle - MSDAORA 



            conn = new OleDbConnection(connectionString);

            conn.Open(); //데이터베이스 연결





            updatedb2();



        }



        private void updatedb2()

        {

            try

            {

                dataGridView1.Rows.Clear();

                dataGridView2.Rows.Clear(); // GridView와 Combobox의 내용을 모두 지우기

                selectTable.Items.Clear();



                //conn.Open(); //데이터베이스 연결

                //SELECT table_name, column_name

                if (txtboxId.Text == "koo1000")

                {

                    label13.Text = "캠핑카 목록/ 대여";

                    label14.Text = "대여확인";

                    

                    users = "캠핑카";

                }





                else if (txtboxId.Text == "koo100")

                {

                    label13.Text = "캠핑카 목록";

                    label14.Text = "대여확인/ 반납처리";

                    users = "캠핑카 where 회사ID = '" + txtboxId.Text + "'";



                }





                else if (txtboxId.Text == "koo300")

                {

                    label13.Text = "정비목록";

                    users = "정비 where 정비소ID = '" + txtboxId.Text + "'";



                }



                OleDbCommand cmd = new OleDbCommand();





                cmd.CommandText = "SELECT* FROM eunhye20164090." + users; // 테이블 불러오기





                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;



                OleDbDataReader read = cmd.ExecuteReader(); //

                count = read.FieldCount; // 해당 테이블의 column 수를 지정

                button5.Visible = true;

                button6.Visible = true;



                dataGridView1.ColumnCount = count;

                //필드명 받아오는 반복문

                for (int i = 0; i < count; i++)

                {

                    dataGridView1.Columns[i].Name = read.GetName(i);

                    textBoxes[i].Visible = true;



                    labels[i].Text = dataGridView1.Columns[i].Name;



                    labels[i].Visible = true;



                    types.Add(read.GetFieldType(i));

                }



                //행 단위로 반복

                while (read.Read())

                {

                    object[] obj = new object[count]; // 필드수만큼 오브젝트 배열



                    for (int i = 0; i < count; i++) // 필드 수만큼 반복

                    {

                        obj[i] = new object();

                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장

                    }



                    dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가

                }



                read.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message); //에러 메세지 

            }





        }



        private void updatedb()



        {



            dataGridView1.Rows.Clear();







            try



            {

                if (conn != null) conn.Close();



                conn.Open(); //데이터베이스 연결



                OleDbCommand cmd = new OleDbCommand();



                //회사로 로그인했을 경우



                cmd.CommandText = "select * from " + selectTable.Text; //해당 테이블의 내용 불러오기





                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                OleDbDataReader read = cmd.ExecuteReader(); //select * from ~ 결과



                count = read.FieldCount; // 해당 테이블의 column 수를 지정



                dataGridView1.ColumnCount = count;







                types.Clear();



                button2.Visible = true;

                button3.Visible = true;

                button4.Visible = true;

                button5.Visible = true;

                //필드명 받아오는 반복문



                for (int i = 0; i < count; i++)



                {



                    dataGridView1.Columns[i].Name = read.GetName(i);



                    textBoxes[i].Visible = true;



                    labels[i].Text = dataGridView1.Columns[i].Name;



                    labels[i].Visible = true;



                    types.Add(read.GetFieldType(i));



                }







                //행 단위로 반복



                while (read.Read())



                {



                    object[] obj = new object[count]; // 필드수만큼 오브젝트 배열







                    for (int i = 0; i < count; i++) // 필드 수만큼 반복



                    {



                        obj[i] = new object();



                        obj[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장



                    }







                    dataGridView1.Rows.Add(obj); //데이터그리드뷰에 오브젝트 배열 추가



                }







                read.Close();



            }



            catch (Exception ex)



            {



                MessageBox.Show("Error: " + ex.Message); //에러 메세지 



            }



        }







        private void button2_Click(object sender, EventArgs e) //추가버튼



        {



            dataGridView1.Rows.Clear();

            string cmdText = "";





            conn = new OleDbConnection(connectionString);



            try



            {



                conn.Open();



                OleDbCommand cmd = new OleDbCommand();





                cmd.CommandText = "SELECT C.COLUMN_NAME FROM USER_CONS_COLUMNS C, USER_CONSTRAINTS S WHERE C.CONSTRAINT_NAME = S.CONSTRAINT_NAME AND S.CONSTRAINT_TYPE = 'P' AND C.TABLE_NAME = '"



                   + selectTable.Text + "'"; // 테이블의 기본키를 가져온다.



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                OleDbDataReader read = cmd.ExecuteReader();



                List<object> PK = new List<object>();







                while (read.Read())



                {



                    PK.Add(read.GetValue(0));



                } // 테이블의 기본 키 지정



                conn.Close();







                conn.Open(); //데이터베이스 연결





                cmdText = "INSERT INTO " + selectTable.Text + " VALUES(";

                if (txtboxId.Text == "koo100")

                {

                    cmdText = "INSERT INTO eunhye20164090.캠핑카 VALUES(";



                }

                if (txtboxId.Text == "koo300")

                {

                    cmdText = "INSERT INTO eunhye20164090.정비 VALUES(";



                }





                for (int j = 0; j < dataGridView1.ColumnCount; j++)



                {



                    if (PK.Contains(labels[j].Text))



                    {



                        if (textBoxes[j].Text != "")



                        {



                            if (types[j] == typeof(System.Decimal) || types[j] == typeof(System.Double))



                                cmdText += textBoxes[j].Text;



                            else



                                cmdText += "'" + textBoxes[j].Text + "'";







                            if (j != dataGridView1.ColumnCount - 1) cmdText += ", ";



                            else cmdText += ")";



                        }



                    }



                    else

                    {



                        if (textBoxes[j].Text != "")

                        {



                            if (types[j] == typeof(System.Decimal) || types[j] == typeof(System.Double))



                                cmdText += textBoxes[j].Text;



                            else



                                cmdText += "'" + textBoxes[j].Text + "'";







                            if (j != dataGridView1.ColumnCount - 1) cmdText += ", ";



                            else cmdText += ")";



                        }







                        else



                        {



                            cmdText += "NULL";



                            if (j != dataGridView1.ColumnCount - 1) cmdText += ", ";



                            else cmdText += ")";



                        }



                    }



                }









                cmd.CommandText = cmdText;



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.



                updatedb();







            }



            catch (Exception ex)



            {



                MessageBox.Show("Error: " + ex.Message); //에러 메세지 



            }



            finally



            {



                if (conn != null)



                {



                    conn.Close(); //데이터베이스 연결 해제



                }



            }



        }







        private void button3_Click(object sender, EventArgs e) //삭제버튼



        {



            dataGridView1.Rows.Clear();







            conn = new OleDbConnection(connectionString);



            try



            {



                conn.Open(); //데이터베이스 연결



                OleDbCommand cmd = new OleDbCommand();







                cmd.CommandText = "SELECT C.COLUMN_NAME FROM USER_CONS_COLUMNS C, USER_CONSTRAINTS S WHERE C.CONSTRAINT_NAME = S.CONSTRAINT_NAME AND S.CONSTRAINT_TYPE = 'P' AND C.TABLE_NAME = '"



                    + selectTable.Text + "'"; // 테이블의 기본키를 가져온다.



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                OleDbDataReader read = cmd.ExecuteReader();



                List<object> PK = new List<object>();







                while (read.Read())



                {



                    PK.Add(read.GetValue(0));



                } // 테이블의 기본 키 지정



                conn.Close();



                conn.Open();

                if (txtboxId.Text == "koo100")

                {



                    selectTable.Text = "eunhye20164090.캠핑카";



                }

                else if (txtboxId.Text == "koo300")

                {



                    selectTable.Text = "eunhye20164090.정비";

                    this.selectTable.Visible = false;



                }







                string cmdText = "DELETE FROM " + selectTable.Text + " WHERE ";







                if (PK.Count != 0)  // 기본키가 있는 경우



                {



                    for (int j = 0; j < PK.Count; j++)



                    {



                        int index = 0;



                        cmdText += PK[j] + " = ";



                        for (int k = 0; k < dataGridView1.ColumnCount; k++)



                        {



                            if (labels[k].Text == PK[j].ToString()) index = k;



                        }



                        if (types[index] == typeof(System.Decimal) || types[index] == typeof(System.Double))



                            cmdText += textBoxes[index].Text;



                        else



                            cmdText += "'" + textBoxes[index].Text + "'";







                        if (j != PK.Count - 1) cmdText += " AND ";



                    }



                }



                else

                { // 기본키가 없는 경우



                    if (types[0] == typeof(System.Decimal) || types[0] == typeof(System.Double))



                        cmdText += labels[0].Text + " = " + textBoxes[0].Text;



                    else



                        cmdText += labels[0].Text + " = '" + textBoxes[0].Text + "'";



                }



                cmd.CommandText = cmdText;



                textBox1.Text = cmd.CommandText; // 기본 키를 기준으로 속성을 삭제한다.







                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.



                updatedb();



            }



            catch (Exception ex)



            {



                MessageBox.Show("Error: " + ex.Message); //에러 메세지 



            }



            finally



            {



                if (conn != null)



                {



                    conn.Close(); //데이터베이스 연결 해제



                }



            }



        }







        private void button4_Click(object sender, EventArgs e) //수정버튼
        {

            conn = new OleDbConnection(connectionString);
            try
            {



                conn.Open(); //데이터베이스 연결



                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "SELECT C.COLUMN_NAME FROM USER_CONS_COLUMNS C, USER_CONSTRAINTS S WHERE C.CONSTRAINT_NAME = S.CONSTRAINT_NAME AND S.CONSTRAINT_TYPE = 'P' AND C.TABLE_NAME = '"



                    + selectTable.Text + "'"; // 테이블의 기본키를 가져온다.



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();

                List<object> PK = new List<object>();
                while (read.Read())
                {



                    PK.Add(read.GetValue(0));



                } // 테이블의 기본 키 지정



                conn.Close();
                conn.Open();

                if (txtboxId.Text == "koo100")

                {



                    selectTable.Text = "eunhye20164090.캠핑카";



                }

                else if (txtboxId.Text == "koo300")

                {



                    selectTable.Text = "eunhye20164090.정비";

                    this.selectTable.Visible = false;



                }







                string cmdText = "UPDATE " + selectTable.Text + " SET ";



                if (PK.Count != 0)



                {



                    for (int j = 0; j < dataGridView1.ColumnCount; j++)



                    {



                        if (PK.Contains(labels[j].Text)) { }



                        else



                        {



                            if (textBoxes[j].Text != "")



                            {



                                if (types[j] == typeof(System.Decimal) || types[j] == typeof(System.Double))



                                    cmdText += labels[j].Text + " = " + textBoxes[j].Text;



                                else



                                    cmdText += labels[j].Text + " = '" + textBoxes[j].Text + "'";



                            }



                            else



                            {



                                cmdText += labels[j].Text + " = NULL";



                            }



                            if (j != dataGridView1.ColumnCount - 1) cmdText += ", ";



                            else cmdText += " WHERE ";



                        }



                    }



                    for (int j = 0; j < PK.Count; j++)



                    {



                        cmdText += PK[j] + " = ";



                        int index = 0;



                        for (int k = 0; k < dataGridView1.ColumnCount; k++)



                        {



                            if (labels[k].Text == PK[j].ToString()) index = k;



                        }



                        if (types[index] == typeof(System.Decimal) || types[index] == typeof(System.Double))



                            cmdText += textBoxes[index].Text;



                        else



                            cmdText += "'" + textBoxes[index].Text + "'";







                        if (j != PK.Count - 1) cmdText += " AND ";



                    }



                }



                else



                {



                    for (int j = 1; j < dataGridView1.ColumnCount; j++)



                    {



                        if (textBoxes[j].Text != "")



                        {



                            if (types[j] == typeof(System.Decimal) || types[j] == typeof(System.Double))



                                cmdText += labels[j].Text + " = " + textBoxes[j].Text;



                            else



                                cmdText += labels[j].Text + " = '" + textBoxes[j].Text + "'";



                        }



                        else



                        {



                            cmdText += labels[j].Text + " = NULL";



                        }



                        if (j != dataGridView1.ColumnCount - 1) cmdText += ", ";



                        else cmdText += " WHERE ";



                    }



                    if (types[0] == typeof(System.Decimal) || types[0] == typeof(System.Double))



                        cmdText += labels[0].Text + " = " + textBoxes[0].Text;



                    else



                        cmdText += labels[0].Text + " = '" + textBoxes[0].Text + "'";



                }
               

                cmd.CommandText = cmdText;



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                if (selectTable.Text == "eunhye20164090.캠핑카")
                {
                    updatedb2();
                }


                else
                {
                    updatedb();

                }
                



            }



            catch (Exception ex)



            {



                MessageBox.Show("Error: " + ex.Message); //에러 메세지 


            }



            finally



            {



                if (conn != null)



                {



                    conn.Close(); //데이터베이스 연결 해제



                }



            }







        }







        private void button5_Click(object sender, EventArgs e) //view 확인



        {





            dataGridView2.Rows.Clear();

            conn = new OleDbConnection(connectionString);



            conn.Open(); //데이터베이스 연결



            OleDbCommand cmd = new OleDbCommand();

            if (txtboxId.Text == "koo1000")

            {

                users = "대여 where 면허증번호 = '" + txtboxId.Text + "'";

            }



            if (txtboxId.Text == "koo100")

            {



                cmd.CommandText = "select a.회사ID, a.캠핑카ID,b.대여번호,b.면허증번호,b.시작일, b.반납여부 " +

                "FROM eunhye20164090.캠핑카 a, eunhye20164090.대여 b where a.회사ID = '" + txtboxId.Text + "' AND a.캠핑카ID = b.캠핑카ID";

                this.selectTable.Visible = false;





            }

            else
            {

                cmd.CommandText = "select * from eunhye20164090." + users; //member 테이블

            }

            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로

            cmd.Connection = conn;



            OleDbDataReader read = cmd.ExecuteReader(); //select * from emp 결과

            count = read.FieldCount; // 해당 테이블의 column 수를 지정



            dataGridView2.ColumnCount = count;

            //필드명 받아오는 반복문

            for (int i = 0; i < count; i++)

            {

                dataGridView2.Columns[i].Name = read.GetName(i);

                textBoxes[i].Visible = true;



                labels[i].Text = dataGridView2.Columns[i].Name;



                labels[i].Visible = true;



                types.Add(read.GetFieldType(i));

            }





            //행 단위로 반복

            while (read.Read())

            {

                object[] list = new object[count]; // 필드수만큼 오브젝트 배열



                for (int i = 0; i < count; i++) // 필드 수만큼 반복

                {

                    list[i] = new object();

                    list[i] = read.GetValue(i); // 오브젝트배열에 데이터 저장

                }



                dataGridView2.Rows.Add(list); //데이터그리드뷰에 오브젝트 배열 추가

            }



            read.Close();

        }





        private void button6_Click(object sender, EventArgs e) //대여하기

        {

            dataGridView2.Rows.Clear();

            string cmdText = "";

            string sysdate = DateTime.Now.ToString("yyyy/MM/dd");





            conn = new OleDbConnection(connectionString);



            try



            {

                if (txtboxId.Text == "koo1000")

                {

                    selectTable.Text = "대여";

                }

                conn.Open();



                OleDbCommand cmd = new OleDbCommand();





                cmd.CommandText = "SELECT C.COLUMN_NAME FROM USER_CONS_COLUMNS C, USER_CONSTRAINTS S WHERE C.CONSTRAINT_NAME = S.CONSTRAINT_NAME AND S.CONSTRAINT_TYPE = 'P' AND C.TABLE_NAME = '"



                   + selectTable.Text + "'"; // 테이블의 기본키를 가져온다.



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                OleDbDataReader read = cmd.ExecuteReader();



                List<object> PK = new List<object>();







                while (read.Read())



                {



                    PK.Add(read.GetValue(0));



                } // 테이블의 기본 키 지정



                conn.Close();

                conn.Open(); //데이터베이스 연결





                cmdText = "INSERT INTO " + selectTable.Text + " VALUES(";



                if (txtboxId.Text == "koo1000")

                {

                    cmdText = "INSERT INTO eunhye20164090." + selectTable.Text + " VALUES(";

                }



                Random random = new Random();

                int x = random.Next(8000, 9000);





                cmdText += "'" + x + "'," + "'" + textBoxes[0].Text + "'," + "'" + txtboxId.Text + "'," + "'" + sysdate + "'," + "'NO')";



                cmd.CommandText = cmdText;



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;



                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.



                updatedb2();

            }



            catch (Exception ex)



            {



                MessageBox.Show("Error: " + ex.Message); //에러 메세지 



            }



            finally



            {



                if (conn != null)



                {



                    conn.Close(); //데이터베이스 연결 해제



                }



            }



        }



        private void txtBoxPw_KeyDown(object sender, KeyEventArgs e)



        {



            if (e.KeyCode == Keys.Enter)



            {



                button1_Click(sender, e);



            }







        }









        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)



        {







            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)



            {



                for (int i = 0; i < count; i++)



                {



                    if (textBoxes[i].Visible == true)

                    {







                        textBoxes[i].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();



                    }



                }

            } // 데이터그리드에서 항목을 선택했을시 텍스트 박스에 내용을 표시해 줌



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)



        {





            if (dataGridView2.Rows[e.RowIndex].Cells[0].Value != null)



            {



                for (int i = 0; i < count; i++)



                {



                    if (textBoxes[i].Visible == true)







                        textBoxes[i].Text = dataGridView2.Rows[e.RowIndex].Cells[i].Value.ToString();



                }



            } // 데이터그리드에서 항목을 선택했을시 텍스트 박스에 내용을 표시해 줌



        }



        private void button7_Click(object sender, EventArgs e) //초기화버튼
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < count; i++)
            {
                textBoxes[i].Clear();
                labels[i].Visible = false;
            }
           


            conn = new OleDbConnection(connectionString);



            conn.Open(); //데이터베이스 연결

            

            if (selectTable.Text == "eunhye20164090.캠핑카")
            {
                updatedb2();
                updatedb();
            }


            else
            {
                updatedb();

            }



        }

        private void button8_Click(object sender, EventArgs e) //반납버튼



        {

            dataGridView2.Rows.Clear();

            string cmdText = "";
            conn = new OleDbConnection(connectionString);
            try



            {

                if (txtboxId.Text == "koo100")

                {

                    selectTable.Text = "eunhye20164090.대여";

                }

                conn.Open();



                OleDbCommand cmd = new OleDbCommand();





                cmd.CommandText = "SELECT C.COLUMN_NAME FROM USER_CONS_COLUMNS C, USER_CONSTRAINTS S WHERE C.CONSTRAINT_NAME = S.CONSTRAINT_NAME AND S.CONSTRAINT_TYPE = 'P' AND C.TABLE_NAME = '"



                   + selectTable.Text + "'"; // 테이블의 기본키를 가져온다.



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;







                OleDbDataReader read = cmd.ExecuteReader();



                List<object> PK = new List<object>();







                while (read.Read())



                {



                    PK.Add(read.GetValue(0));



                } // 테이블의 기본 키 지정



                conn.Close();

                conn.Open(); //데이터베이스 연결



                cmdText = "UPDATE " + selectTable.Text + " SET  반납여부 = 'YES' where " + label4.Text + " ='koo200'";

                cmd.CommandText = cmdText;



                textBox1.Text = cmd.CommandText;



                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로



                cmd.Connection = conn;



                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.



                updatedb2();

            }

            catch (Exception ex)



            {



                MessageBox.Show("Error: " + ex.Message); //에러 메세지 



            }



            finally



            {



                if (conn != null)



                {



                    conn.Close(); //데이터베이스 연결 해제



                }



            }





        }









        private void selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {

                textBoxes[i].Visible = false;

                labels[i].Visible = false;



            }



            // 화면에 보이는 텍스트박스와 레이블을 모두 숨김



            button7_Click(sender, e);





        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {





        }



        private void label13_Click(object sender, EventArgs e)

        {



        }

    }



}