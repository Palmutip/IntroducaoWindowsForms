namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            gbxExercicios.Visible = true;
        }

        private void rdoint_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdoint.Checked)
            {
                txtint.Enabled = true;
                pnlint.Visible = true;
            }               
            else
                txtint.Enabled = false;
        }

        private void rdodecimal_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdodecimal.Checked)
            {
                txtdecimal.Enabled = true;
                pnldecimal.Visible = true;
            }               
            else
                txtdecimal.Enabled = false;
        }

        private void rdofloat_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdofloat.Checked)
            {
                txtfloat.Enabled = true;
                pnlfloat.Visible = true;    
            }               
            else
                txtfloat.Enabled = false;
        }

        private void rdodouble_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdodouble.Checked)
            {
                txtdouble.Enabled = true;
                pnldouble.Visible = true;
            }  
            else
                txtdouble.Enabled = false;
        }

        private void rdostring_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdostring.Checked)
            {
                txtstring.Enabled = true;
                pnlstring.Visible = true;
            }
            else
                txtstring.Enabled = false;
        }

        private void rdochar_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdochar.Checked)
            {
                txtchar.Enabled = true;
                pnlchar.Visible = true;
            }                
            else
                txtchar.Enabled = false;
        }

        private void rdovar_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdovar.Checked)
            {
                txtvar.Enabled = true;
                pnlvar.Visible = true;
            }               
            else
                txtvar.Enabled = false;
        }

        private void rdodate_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdodate.Checked)
            {
                txtdatetime.Enabled = true;
                pnldatetime.Visible= true;
            }               
            else
                txtdatetime.Enabled = false;
        }

        private void rdobool_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdobool.Checked)
            {
                chkbool.Enabled = true;
                pnlbool.Visible = true;
            }              
            else
                chkbool.Enabled = false;
        }

        private void rdolist_CheckedChanged(object sender, EventArgs e)
        {
            EsconderPaineis();

            if (rdolist.Checked)
            {
                cmblist.Enabled = true;
                pnllist.Visible= true;
            }                
            else
                cmblist.Enabled = false;
        }

        private void btnAbreExercicio_Click(object sender, EventArgs e)
        {
            gbxExercicios.Visible = true;

            EsconderPaineis();

            if (rdolist.Checked)
            {
                pnllist.Visible = true;
            }
            else if (rdobool.Checked)
            {
                pnlbool.Visible = true;

                if (chkbool.Checked)
                    lblconfirmacao.Text = "Eu FIZ esse Exercicio";
                else
                    lblconfirmacao.Text = "Eu NÃO vi esse Exercicio";
            }
            else if (rdodate.Checked)
            {
                pnldatetime.Visible = true;

                lbldataamostrar.Text = txtdatetime.Value.ToShortDateString();
            }
            else if (rdovar.Checked)
            {
                pnlvar.Visible = true;

                lblresultadovar.Text = "Sua variavel pode ser dos seguintes tipos abaixo:";

                try
                {
                    DateTime date = Convert.ToDateTime(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "DateTime";
                }
                catch { }
                try
                {
                    bool boleano = Convert.ToBoolean(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "bool";
                }
                catch { }
                try
                {
                    char caractere = Convert.ToChar(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "char";
                }
                catch { }
                try
                {
                    string texto = Convert.ToString(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "string";
                }
                catch { }
                try
                {
                    double duplaPrecisao = Convert.ToDouble(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "double";
                }
                catch { }
                try
                {
                    float unicaPrecisao = Convert.ToSingle(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "float";
                }
                catch { }
                try
                {
                    decimal numeroDecimal = Convert.ToDecimal(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "decimal";
                }
                catch { }
                try
                {
                    int inteiro = Convert.ToInt32(txtvar.Text);

                    lblresultadovar.Text += Environment.NewLine + "int";
                }
                catch { }
                try
                {
                    var generica = txtvar.Text;

                    lblresultadovar.Text += Environment.NewLine + "var";
                }
                catch { }
            }
            else if (rdochar.Checked)
            {
                pnlchar.Visible = true;
            }
            else if (rdostring.Checked)
            {
                pnlstring.Visible = true;

                string nome = txtstring.Text;

                lblcarta.Text = "Esta é uma carta para " + nome + "\r\nA partir daqui seu texto continua";
            }
            else if (rdodouble.Checked)
            {
                pnldouble.Visible = true;

                txtreceberesto.Text = txtdouble.Text;

                double valor = Convert.ToDouble(txtreceberesto.Text);

                lblresto.Text += (valor % 3).ToString();
            }
            else if (rdofloat.Checked)
            {
                pnlfloat.Visible = true;

                txtdivisao.Text = txtfloat.Text;

                float valor = Convert.ToSingle(txtdivisao.Text);

                lbldivisao.Text += (valor / 2).ToString();
            }
            else if (rdodecimal.Checked)
            {
                pnldecimal.Visible = true;

                txtmultiplicacao.Text = txtdecimal.Text;

                decimal valor = Convert.ToDecimal(txtmultiplicacao.Text);

                lblmultiplicacao.Text += (valor * 1.5m).ToString();
            }
            else if (rdoint.Checked)
            {
                pnlint.Visible = true;

                txtRecebeint.Text = txtint.Text;

                int resultado = Convert.ToInt32(txtRecebeint.Text) + 5;

                lblresultint.Text = lblresultint.Text + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Opção inválida");
            }
        }

        private void EsconderPaineis()
        {
            pnlint.Visible = false;
            pnldecimal.Visible = false;
            pnlfloat.Visible = false;
            pnldouble.Visible = false;
            pnlchar.Visible = false;
            pnlvar.Visible = false;
            pnldatetime.Visible = false;
            pnlbool.Visible = false;
            pnllist.Visible = false;
            pnlstring.Visible = false;

            listboxtipo.Items.Clear();
            listboxresult.Items.Clear();
            txtcomparador.Text = "";

            lblresultint.Text = " + 5 = ";
            lblresto.Text = "% 3 = ";
            lbldivisao.Text = "/ 2 = ";
            lblmultiplicacao.Text = "* 1,5 = ";

            lblAvisoLista.Visible = true;
            lblAvisoLista.Text = "";
        }

        private void btnadicionarelemento_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmblist.Text)
                {
                    case "DateTime":
                        DateTime data = Convert.ToDateTime(txtelementolista.Text);
                        break;
                    case "bool":
                        bool boleano = Convert.ToBoolean(txtelementolista.Text);
                        break;
                    case "float":
                        float unicaPrecisao = Convert.ToSingle(txtelementolista.Text);
                        break;
                    case "int":
                        int inteiro = Convert.ToInt32(txtelementolista.Text);
                        break;
                    case "decimal":
                        decimal numDecimal = Convert.ToDecimal(txtelementolista.Text);
                        break;
                    case "double":
                        double duplaPrecisao = Convert.ToDouble(txtelementolista.Text);
                        break;
                    case "string":
                        string texto = Convert.ToString(txtelementolista.Text);
                        break;
                    case "char":
                        char caractere = Convert.ToChar(txtelementolista.Text);
                        break;
                    case "var":
                        var generico = txtelementolista.Text;
                        break;
                }

                listboxtipo.Items.Add(txtelementolista.Text);

                lblAvisoLista.Visible = false;
                lblAvisoLista.Text = "";
            }
            catch 
            {
                lblAvisoLista.Visible = true;
                lblAvisoLista.Text = "Atenção, o valor inserido é incompatível com o tipo definido na lista";
            }
        }

        private void txtcomparador_TextChanged(object sender, EventArgs e)
        {
            int quantidade = 0;

            foreach (char c in txtcomparador.Text)
            {
                if(c == Convert.ToChar(txtchar.Text))
                    quantidade = quantidade + 1;
            }

            lblresultchar.Text = "Seu caracter apareceu " + quantidade.ToString() +" vezes";
        }

        private void cmblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxtipo.Items.Clear();
            lblAvisoLista.Visible = false;
            lblAvisoLista.Text = "";
        }

        private void btnMesPar_Click(object sender, EventArgs e)
        {
            lblAvisoLista.Visible = false;
            lblAvisoLista.Text = "";

            try
            {
                List<DateTime> datas = new List<DateTime>();

                foreach (var item in listboxtipo.Items)
                {
                    DateTime dataAtual = Convert.ToDateTime(item);
                    if (dataAtual.Month % 2 == 0)
                        datas.Add(dataAtual);
                }

                foreach (DateTime data in datas)
                {
                    listboxresult.Items.Add(data.ToShortDateString());
                }
            }
            catch
            {
                lblAvisoLista.Visible = true;
                lblAvisoLista.Text = "Atenção, o valor inserido é incompatível com o tipo definido na lista";
            }
        }

        private void btnNumeroPar_Click(object sender, EventArgs e)
        {
            lblAvisoLista.Visible = false;
            lblAvisoLista.Text = "";

            try
            {
                List<int> numeros = new List<int>();

                foreach (var item in listboxtipo.Items)
                {
                    int numeroAtual = Convert.ToInt32(item);
                    if (numeroAtual % 2 == 0)
                        numeros.Add(numeroAtual);
                }

                foreach (int numero in numeros)
                {
                    listboxresult.Items.Add(numero.ToString());
                }
            }
            catch
            {
                lblAvisoLista.Visible = true;
                lblAvisoLista.Text = "Atenção, o valor inserido é incompatível com o tipo definido na lista";
            }            
        }

        private void btnApenasVogais_Click(object sender, EventArgs e)
        {
            lblAvisoLista.Visible = false;
            lblAvisoLista.Text = "";

            try
            {
                List<string> palavras = new List<string>();

                foreach (var item in listboxtipo.Items)
                {
                    string palavraAtual = item.ToString();

                    foreach (char letra in palavraAtual)
                    {
                        if (letra == 'A' || letra == 'a' || letra == 'E' || letra == 'e' || letra == 'I' || letra == 'i' || letra == 'O' || letra == 'o' || letra == 'U' || letra == 'u')
                        {
                            palavras.Add(palavraAtual);
                            break;
                        }
                    }

                }

                List<char> letras = new List<char>();

                foreach (string palavra in palavras)
                {
                    foreach (char letra in palavra)
                    {
                        if (letra == 'A' || letra == 'a' || letra == 'E' || letra == 'e' || letra == 'I' || letra == 'i' || letra == 'O' || letra == 'o' || letra == 'U' || letra == 'u')
                        {
                            if (!letras.Contains(letra))
                            {
                                letras.Add(letra);
                                listboxresult.Items.Add(letra.ToString());
                            }
                        }
                    }

                }
            }
            catch
            {
                lblAvisoLista.Visible = true;
                lblAvisoLista.Text = "Atenção, o valor inserido é incompatível com o tipo definido na lista";
            }
            
        }

        private void btnApenasVerdade_Click(object sender, EventArgs e)
        {
            lblAvisoLista.Visible = false;
            lblAvisoLista.Text = "";

            try
            {
                List<bool> logicos = new List<bool>();

                foreach (var item in listboxtipo.Items)
                {
                    bool situacao = Convert.ToBoolean(item);
                    if (situacao)
                        logicos.Add(situacao);
                }

                foreach (bool logico in logicos)
                {
                    listboxresult.Items.Add(logico);
                }
            }
            catch
            {
                lblAvisoLista.Visible = true;
                lblAvisoLista.Text = "Atenção, o valor inserido é incompatível com o tipo definido na lista";
            }            
        }
    }
}