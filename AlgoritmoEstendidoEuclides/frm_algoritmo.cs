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

            numa = Math.Max(int.Parse(num_a.Text), int.Parse(num_b.Text)); //o maior n�mero entra na vari�vel numA
            numb = Math.Min(int.Parse(num_a.Text), int.Parse(num_b.Text)); //o menor n�mero entra na vari�vel numB

            int a = numa; //armazenando o maior numero
            int b = numb; //armazenando o menor numero
            int combLinear = combinacaoLinear(a, b); //calculando a combina��o linear

            while (resto != 0) //enquanto o resto n�o for 0, continuar a divis�o
            {
                quoc = numa / numb; //quociente dos dois n�meros
                resto = numa % numb; //resto da divis�o, que ser� o divisor da pr�xima divis�o

                ltx_passo.Items.Add($"{numa} = {numb} . {quoc} + {resto}"); //exibe a equa��o no passo a passo

                numa = numb; //maior n�mero vira o dividendo da divis�o anterior
                numb = resto; //o resto vira o divisor da pr�xima divis�o
            }
            //resultado � o �ltimo resto antes do resto ser igual a 0
            ltx_passo.Items.Add($"MDC({num_a.Text}, {num_b.Text}) = {numa}"); //mostra o resultado do mdc
            ltx_passo.Items.Add("Combina��o Linear:");
            if (t >= 0) //se o segundo termo da combina��o linear for negativo, tirar o +
                ltx_passo.Items.Add($"{combLinear} = {s} . {a} + {t} . {b}"); //mostra a combina��o linear
            else
                ltx_passo.Items.Add($"{combLinear} = {s} . {a} - {Math.Abs(t)} . {b}"); //mostra a combina��o linear
        }
    }
}