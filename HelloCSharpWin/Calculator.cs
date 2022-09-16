using System;

namespace HelloCSharpWin
{
    public enum Operators {Add, Sub, Multi, Div}
    public partial class Calculator : Form
    {
        public decimal Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;
        public Calculator()
        {
            InitializeComponent();
        }

        public decimal Add(decimal number1, decimal number2)
        {
            decimal add = number1 + number2; 
            return add; 
        }

        public decimal Sub(decimal number1, decimal number2)
        {
            decimal sub = number1 - number2;
            return sub;    
        }

        public decimal Multi(decimal number1, decimal number2)
        {
            decimal multi = number1 * number2;
            return multi;
        }

        public decimal Div(decimal number1, decimal number2)
        {
            decimal div = number1 / number2;
            return div;
        }

        public void SetNum(string num)
        {
            /*
            if (NumScreen.Text == "0")
                NumScreen.Text = num;
            else NumScreen.Text = NumScreen.Text + num;
            */

            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }

            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }

            
            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        // 변수 = 0
        // 연산자 = +

        // 숫자 입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장한 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.
        // 숫자 입력
        // 연산자 버튼 - 숫자 완성, 변수와 숫자를 저장된 연산자로 연산, 결과를 변수에 저장, 현재 연산자를 저장.
        private void NumPlus_Click(object sender, EventArgs e)
        {   
            // 예외처리
            if (isNewNum == false)
            {
                //decimal.parse = 숫자형으로 
                decimal num = decimal.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                    Result = Add(Result, num);
                else if (Opt == Operators.Sub)
                    Result = Sub(Result, num);
                else if (Opt == Operators.Multi)
                    Result = Multi(Result, num);
                else if (Opt == Operators.Div)
                    Result = Div(Result, num);

                //ToSTring = 문자형으로
                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "×")
                Opt = Operators.Multi;
            else if (optButton.Text == "÷")
                Opt = Operators.Div;

        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
        /*
        public void Setdecimal(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }

            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }

            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }
        */

        // 소슷점 만들기
        private void float_Click(object sender, EventArgs e)
        {
            // . 한번이상 안찍히게 하기
            int count = 0;
            for (int i = 0; i < NumScreen.Text.Length; i++)
            {
                if (NumScreen.Text[i] == '.') count++;
            }
            if (count >= 1) return;

            // .연속으로 안찍히게 만들기
            //else if (NumScreen.Text[NumScreen.Text.Length - 1] == '.') return;

            else if(NumScreen.Text == "0")
                    NumScreen.Text = "0.";


            else NumScreen.Text = NumScreen.Text + '.';
        }
    }
}