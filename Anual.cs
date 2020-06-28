namespace RelatoriosPOO
{
    public class Anual : Relatorio  //Anual herança de relatório
    {
	    public override void MostrarRelatorio(){
		base.MostrarRelatorio();
		System.Console.WriteLine("Mostrando relatório por ano");

        }
    }
}