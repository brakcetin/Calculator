namespace Calculator
{
    public partial class Form1 : Form
    {
        bool cmd = false; //the operation buttons are not pressed
        double result = 0;
        string cmdsign = ""; //selected math operation
        public Form1()
        {
            InitializeComponent();
        }

        private void number(object sender, EventArgs e)
        {
            if(Result.Text== "0" || cmd) //It deletes the marks and the '0' at the beginning.
            {
                Result.Clear();
            }
            cmd= false;
            Button button = (Button)sender; //assigns the selected number to the button
            Result.Text += button.Text; //prints the selected digit
        }

        private void cmdCalc(object sender, EventArgs e)
        {
            cmd= true; //pressed one of the operator
            Button button = (Button)sender; //assigns the selected operator to the button
            string newcmdsign = button.Text;
            ResultLbl.Text = ResultLbl.Text + " " + Result.Text + " " + newcmdsign;
            switch(cmdsign) 
            {
                case "+":
                    Result.Text = (result + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (result - Double.Parse(Result.Text)).ToString();
                    break;
                case "x":
                    Result.Text = (result * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (result / Double.Parse(Result.Text)).ToString();
                    break;
                case "%":
                    Result.Text = (result % Double.Parse(Result.Text)).ToString();
                    break;
            }
            result = Double.Parse(Result.Text);
            Result.Text = result.ToString();
            cmdsign= newcmdsign;

        }

        private void acbutton_Click(object sender, EventArgs e)
        {
            //resets the result
            Result.Text = "0";
        }

        private void C_btn_Click(object sender, EventArgs e)
        {
            //resets the result and the transaction description
            Result.Text = "0";
            ResultLbl.Text = "";
            cmdsign = "";
            result = 0;
            cmd = false;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            cmd = true;
            ResultLbl.Text= "";
            switch (cmdsign)
            {
                case "+":
                    Result.Text = (result + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (result - Double.Parse(Result.Text)).ToString();
                    break;
                case "x":
                    Result.Text = (result * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (result / Double.Parse(Result.Text)).ToString();
                    break;
                case "%":
                    Result.Text = (result % Double.Parse(Result.Text)).ToString();
                    break;
            }
            result = Double.Parse(Result.Text);
            Result.Text = result.ToString();
            cmdsign = "";

        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (cmd)
            {
                //After pressing the operator, it puts '0'
                Result.Text = "0";
            }
            if (!Result.Text.Contains(","))
            {
                //puts a comma if there is no comma
                Result.Text += ",";
            }
            cmd = false;
        }
    }
}