namespace AlgoritmoEstendidoEuclides
{
    public partial class frm_algoritmo : Form
    {
        public frm_algoritmo()
        {
            InitializeComponent();
        }

        int s, t;

        int combinacaoLinear(int a, int b)
        {
            if (b == 0)
            {
                s = 1;
                t = 0;
                return a;
            }

            int resultado = combinacaoLinear(b, a % b);

            int tempS = s;
            s = t;
            t = tempS - (a / b) * t;

            return resultado;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int numa, numb, quoc, resto;
            resto = 1;
            ltx_passo.Items.Clear(); //limpando o passo a passo

            numa = Math.Max(int.Parse(num_a.Text), int.Parse(num_b.Text)); //o maior número entra na variável numA
            numb = Math.Min(int.Parse(num_a.Text), int.Parse(num_b.Text)); //o menor número entra na variável numB

            int a = numa; //armazenando o maior numero
            int b = numb; //armazenando o menor numero
            int combLinear = combinacaoLinear(a, b); //calculando a combinação linear

            while (resto != 0) //enquanto o resto não for 0, continuar a divisão
            {
                quoc = numa / numb; //quociente dos dois números
                resto = numa % numb; //resto da divisão, que será o divisor da próxima divisão

                ltx_passo.Items.Add($"{numa} = {numb} . {quoc} + {resto}"); //exibe a equação no passo a passo

                numa = numb; //maior número vira o dividendo da divisão anterior
                numb = resto; //o resto vira o divisor da próxima divisão
            }
            //resultado é o último resto antes do resto ser igual a 0
            ltx_passo.Items.Add($"MDC({num_a.Text}, {num_b.Text}) = {numa}"); //mostra o resultado do mdc
            ltx_passo.Items.Add("Combinação Linear:");
            if (t >= 0) //se o segundo termo da combinação linear for negativo, tirar o +
                ltx_passo.Items.Add($"{combLinear} = {s} . {a} + {t} . {b}"); //mostra a combinação linear
            else
                ltx_passo.Items.Add($"{combLinear} = {s} . {a} - {Math.Abs(t)} . {b}"); //mostra a combinação linear
        }
    }
}