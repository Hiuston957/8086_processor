//autor: Łukasz Kutyński, Nr albumu:14546 
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
namespace processor_8086
{
    public partial class S : Form
    {
        Label[] memory_label = new Label[256];
        System.Windows.Forms.TextBox[] memory = new System.Windows.Forms.TextBox[256];
        int typ = 1;
        int typrejpam = 1;
        public S()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            {
                int licznik = 0;
                int pozx = 10;
                int pozy = 10;

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 32; j++)
                    {
                        memory_label[licznik] = new Label()
                        {
                            Location = new Point(pozx + i * 120, pozy + j * 50),
                        };

                        memory[licznik] = new System.Windows.Forms.TextBox()
                        {
                            Location = new Point(
                                memory_label[licznik].Location.X,
                                memory_label[licznik].Bounds.Bottom + Padding.Top
                            ),
                        };

                        memory[licznik].TextChanged += new EventHandler(check_validation);

                        string hexValue = licznik.ToString("X");
                        if (hexValue.Length < 2)
                            memory_label[licznik].Text = $"0x0{hexValue}:";
                        else
                            memory_label[licznik].Text = $"0x{hexValue}:";

                        panel1.Controls.Add(memory_label[licznik]);
                        memory[licznik].Text = "0x00";
                        panel1.Controls.Add(memory[licznik]);

                        licznik++;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (typ == 1)
                rejestr_rejestr(); // operacje na rejestrach
            else if (typ == 2)
                rejestr_memory(); // operacje rejestr do pamięci
            else
                memory_rejestr(); // operacje paięć do roejestru
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e) { }

        public void radioButton1_CheckedChanged(object sender, EventArgs e) // przycisk wykonaj
        {
            typ = 1;

            label9.Visible = false;
            panel1.Visible = false;
            panel3.Visible = false;

            listBox3.Visible = true;
            label8.Visible = true;

            listBox2.Visible = true;
            label7.Visible = true;
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            typ = 2;
            label9.Visible = true;
            panel1.Visible = true;
            panel3.Visible = true;

            listBox3.Visible = false;
            label8.Visible = false;

            listBox2.Visible = true;
            label7.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            typ = 3;
            label9.Visible = true;
            panel1.Visible = true;
            panel3.Visible = true;

            listBox3.Visible = true;
            label8.Visible = true;

            listBox2.Visible = false;
            label7.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e) { }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void AX_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0][x][A-Z0-9]{2}$")).IsMatch(AX.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void BX_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0][x][A-Z0-9]{2}$")).IsMatch(BX.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void CX_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0][x][A-Z0-9]{2}$")).IsMatch(CX.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void DX_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0][x][A-F0-9]{2}$")).IsMatch(DX.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void label10_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            typrejpam = 1;
        }

        private void label12_Click(object sender, EventArgs e) { }

        private void DISP_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0][x][A-F0-9]{2}$")).IsMatch(DISP.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            typrejpam = 2;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            typrejpam = 3;
        }

        private void BP_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[0][x][A-Z0-9]{2}$")).IsMatch(BP.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void check_validation(object sender, EventArgs e) // walidacja komórek
        {
            System.Windows.Forms.TextBox qwer = sender as System.Windows.Forms.TextBox;

            if ((new Regex(@"^[0][x][A-F0-9]{2}$")).IsMatch(qwer.Text))
            {
                button_wykonaj1.Enabled = true;
            }
            else
            {
                button_wykonaj1.Enabled = false;
            }
        }

        private void rejestr_rejestr() //operacje rejestr-rejestr
        {
            int rozkaz = int.Parse(listBox1.GetItemText(listBox1.SelectedIndex));
            string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
            string cel = listBox3.GetItemText(listBox3.SelectedItem);

            string temp = " ";
            string temp1 = " ";

            if (rozkaz == 0)
            {
                switch (zrodlo)
                {
                    case "AX":
                        temp = AX.Text;
                        break;
                    case "BX":
                        temp = BX.Text;
                        break;
                    case "CX":
                        temp = CX.Text;
                        break;
                    case "DX":
                        temp = DX.Text;
                        break;
                    default:
                        return;
                }

                switch (cel)
                {
                    case "AX":
                        AX.Text = temp;
                        break;
                    case "BX":
                        BX.Text = temp;
                        break;
                    case "CX":
                        CX.Text = temp;
                        break;
                    case "DX":
                        DX.Text = temp;
                        break;
                    default:
                        return;
                }
            }
            else if (rozkaz == 1)
            {
                switch (zrodlo)
                {
                    case "AX":
                        temp = AX.Text;
                        break;
                    case "BX":
                        temp = BX.Text;
                        break;
                    case "CX":
                        temp = CX.Text;
                        break;
                    case "DX":
                        temp = DX.Text;
                        break;
                    default:
                        return;
                }

                switch (cel)
                {
                    case "AX":
                        temp1 = AX.Text;
                        AX.Text = temp;
                        break;
                    case "BX":
                        temp1 = BX.Text;
                        BX.Text = temp;
                        break;
                    case "CX":
                        temp1 = CX.Text;
                        CX.Text = temp;
                        break;
                    case "DX":
                        temp1 = DX.Text;
                        DX.Text = temp;
                        break;
                    default:
                        return;
                }

                switch (zrodlo)
                {
                    case "AX":
                        AX.Text = temp1;
                        break;
                    case "BX":
                        BX.Text = temp1;
                        break;
                    case "CX":
                        CX.Text = temp1;
                        break;
                    case "DX":
                        DX.Text = temp1;
                        break;
                }
            }
            else
                return;
        }

        private void rejestr_memory() //operacje rejestr-pamięć
        {
            int rozkaz = int.Parse(listBox1.GetItemText(listBox1.SelectedIndex));

            if (rozkaz == 0)
            {
                /*adresowanie bazowe*/
                if (typrejpam == 1)
                {
                    string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    switch (zrodlo)
                    {
                        case "AX":
                            temp = AX.Text;
                            break;
                        case "BX":
                            temp = BX.Text;
                            break;
                        case "CX":
                            temp = CX.Text;
                            break;
                        case "DX":
                            temp = DX.Text;
                            break;
                        default:
                            return;
                    }

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    memory[suma].Text = temp;
                }
                /*adresowanie indeksowe*/
                else if (typrejpam == 2)
                {
                    string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    switch (zrodlo)
                    {
                        case "AX":
                            temp = AX.Text;
                            break;
                        case "BX":
                            temp = BX.Text;
                            break;
                        case "CX":
                            temp = CX.Text;
                            break;
                        case "DX":
                            temp = DX.Text;
                            break;
                        default:
                            return;
                    }

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    memory[suma].Text = temp;
                }
                /*adresowanie indeksowo-bazowe*/
                if (typrejpam == 3)
                {
                    string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    switch (zrodlo)
                    {
                        case "AX":
                            temp = AX.Text;
                            break;
                        case "BX":
                            temp = BX.Text;
                            break;
                        case "CX":
                            temp = CX.Text;
                            break;
                        case "DX":
                            temp = DX.Text;
                            break;
                        default:
                            return;
                    }

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    memory[suma].Text = temp;
                }
            }
            else if (rozkaz == 1)
            {
                /*adresowanie bazowe*/
                if (typrejpam == 1)
                {
                    string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    switch (zrodlo)
                    {
                        case "AX":
                            temp = AX.Text;
                            break;
                        case "BX":
                            temp = BX.Text;
                            break;
                        case "CX":
                            temp = CX.Text;
                            break;
                        case "DX":
                            temp = DX.Text;
                            break;
                        default:
                            return;
                    }

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    string temp1 = memory[suma].Text; // wartość pamieci

                    memory[suma].Text = temp; //

                    switch (zrodlo)
                    {
                        case "AX":
                            AX.Text = temp1;
                            break;
                        case "BX":
                            BX.Text = temp1;
                            break;
                        case "CX":
                            CX.Text = temp1;
                            break;
                        case "DX":
                            DX.Text = temp1;
                            break;
                        default:
                            return;
                    }
                }
                else if (typrejpam == 1)
                {
                    string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    switch (zrodlo)
                    {
                        case "AX":
                            temp = AX.Text;
                            break;
                        case "BX":
                            temp = BX.Text;
                            break;
                        case "CX":
                            temp = CX.Text;
                            break;
                        case "DX":
                            temp = DX.Text;
                            break;
                        default:
                            return;
                    }

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    string temp1 = memory[suma].Text; // wartość pamieci

                    memory[suma].Text = temp; //

                    switch (zrodlo)
                    {
                        case "AX":
                            AX.Text = temp1;
                            break;
                        case "BX":
                            BX.Text = temp1;
                            break;
                        case "CX":
                            CX.Text = temp1;
                            break;
                        case "DX":
                            DX.Text = temp1;
                            break;
                        default:
                            return;
                    }
                    //------------------------------------------------------------------------------------------------------

                }
                else if (typrejpam == 2)
                {
                    string zrodlo = listBox2.GetItemText(listBox2.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    switch (zrodlo)
                    {
                        case "AX":
                            temp = AX.Text;
                            break;
                        case "BX":
                            temp = BX.Text;
                            break;
                        case "CX":
                            temp = CX.Text;
                            break;
                        case "DX":
                            temp = DX.Text;
                            break;
                        default:
                            return;
                    }

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    string temp1 = memory[suma].Text; // wartość pamieci

                    memory[suma].Text = temp; //

                    switch (zrodlo)
                    {
                        case "AX":
                            AX.Text = temp1;
                            break;
                        case "BX":
                            BX.Text = temp1;
                            break;
                        case "CX":
                            CX.Text = temp1;
                            break;
                        case "DX":
                            DX.Text = temp1;
                            break;
                        default:
                            return;
                    }
                }
                else
                    return;
            }
            else
            {
                return;
            }
        }

        private void memory_rejestr() //operacje pamięć-rejestr
        {
            int rozkaz = int.Parse(listBox1.GetItemText(listBox1.SelectedIndex));

            if (rozkaz == 0)
            {
                /*adresowanie bazowe*/
                if (typrejpam == 1)
                {
                    string cel = listBox3.GetItemText(listBox3.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    temp = memory[suma].Text;

                    switch (cel)
                    {
                        case "AX":
                            AX.Text = temp;
                            break;
                        case "BX":
                            BX.Text = temp;
                            break;
                        case "CX":
                            CX.Text = temp;
                            break;
                        case "DX":
                            DX.Text = temp;
                            break;
                        default:
                            return;
                    }
                }
                /*adresowanie indeksowe*/
                else if (typrejpam == 2)
                {
                    string cel = listBox3.GetItemText(listBox3.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    temp = memory[suma].Text;

                    switch (cel)
                    {
                        case "AX":
                            AX.Text = temp;
                            break;
                        case "BX":
                            BX.Text = temp;
                            break;
                        case "CX":
                            CX.Text = temp;
                            break;
                        case "DX":
                            DX.Text = temp;
                            break;
                        default:
                            return;
                    }
                }
                /*adresowanie indeksowo-bazowe*/
                if (typrejpam == 3)
                {
                    string cel = listBox3.GetItemText(listBox3.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    temp = memory[suma].Text;

                    switch (cel)
                    {
                        case "AX":
                            AX.Text = temp;
                            break;
                        case "BX":
                            BX.Text = temp;
                            break;
                        case "CX":
                            CX.Text = temp;
                            break;
                        case "DX":
                            DX.Text = temp;
                            break;
                        default:
                            return;
                    }
                }
                
            }
            else if (rozkaz == 1)
            {
                /*adresowanie bazowe*/
                if (typrejpam == 1)
                {
                    string cel = listBox3.GetItemText(listBox3.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    temp = memory[suma].Text;
                    string temp1;

                    switch (cel)
                    {
                        case "AX":
                            temp1 = AX.Text;
                            AX.Text = temp;
                            break;
                        case "BX":
                            temp1 = BX.Text;
                            BX.Text = temp;
                            break;
                        case "CX":
                            temp1 = CX.Text;
                            CX.Text = temp;
                            break;
                        case "DX":
                            temp1 = DX.Text;
                            DX.Text = temp;
                            break;
                        default:
                            return;
                    }

                    memory[suma].Text = temp1;
                }
                /*adresowanie indeksowe*/
                else if (typrejpam == 2)
                {
                    string cel = listBox3.GetItemText(listBox3.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    string BPtext;
                    BPtext = BP.Text.Substring(2, 2);

                    suma =
                        suma
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    temp = memory[suma].Text;

                    string temp1;

                    switch (cel)
                    {
                        case "AX":
                            temp1 = AX.Text;
                            AX.Text = temp;
                            break;
                        case "BX":
                            temp1 = BX.Text;
                            BX.Text = temp;
                            break;
                        case "CX":
                            temp1 = CX.Text;
                            CX.Text = temp;
                            break;
                        case "DX":
                            temp1 = DX.Text;
                            DX.Text = temp;
                            break;
                        default:
                            return;
                    }

                    memory[suma].Text = temp1;

                }
                /*adresowanie indeksowo-bazowe*/
                if (typrejpam == 3)
                {
                    string cel = listBox3.GetItemText(listBox3.SelectedItem);
                    string temp = " ";

                    int suma = 0;

                    suma =
                        suma
                        + int.Parse(
                            BP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            SI.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        )
                        + int.Parse(
                            DISP.Text.Substring(2, 2),
                            System.Globalization.NumberStyles.HexNumber
                        );

                    temp = memory[suma].Text;

                    string temp1;

                    switch (cel)
                    {
                        case "AX":
                            temp1 = AX.Text;
                            AX.Text = temp;
                            break;
                        case "BX":
                            temp1 = BX.Text;
                            BX.Text = temp;
                            break;
                        case "CX":
                            temp1 = CX.Text;
                            CX.Text = temp;
                            break;
                        case "DX":
                            temp1 = DX.Text;
                            DX.Text = temp;
                            break;
                        default:
                            return;
                    }

                    memory[suma].Text = temp1;

                }








            }
            else return;


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}




