namespace AlgoritmoEstendidoEuclides
{
    public partial class frm_algoritmo : Form
    {
        public frm_algoritmo()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int numa, numb, quoc, resto;
            resto = 1;
            string passo = $"MDC({txt_numA.Text}, {txt_numB.Text}) = \r\n"; //string do passo a passo

            numa = Math.Max(int.Parse(txt_numA.Text), int.Parse(txt_numB.Text)); //o maior número entra na variável numA
            numb = Math.Min(int.Parse(txt_numA.Text), int.Parse(txt_numB.Text)); //o menor número entra na variável numB

            while (resto != 0) //enquanto o resto não for 0, continuar a divisão
            {
                quoc = numa / numb; //quociente dos dois números
                resto = numa % numb; //resto da divisão, que será o divisor da próxima divisão

                passo += $"{numa} = {numb} . {quoc} + {resto}\r\n"; //exibe a equação no passo a passo

                numa = numb; //maior número vira o dividendo da divisão anterior
                numb = resto; //o resto vira o divisor da próxima divisão
            }
            //resultado é o último resto antes do resto ser igual a 0
            passo += $"MDC({txt_numA.Text}, {txt_numB.Text}) = {numa}"; //final do passo a passo, mostra o resultado
            txt_resultado.Text = passo; //exibindo o resultado na tela
        }
    }
}