namespace RelatoriosPOO
{
    public class Mensal : Relatorio  // Mensal herança de relatório
    {
        public override void MostrarRelatorio(){

		base.MostrarRelatorio();

		System.Console.WriteLine("Mostrando relatório por mês");

        }
    }
}