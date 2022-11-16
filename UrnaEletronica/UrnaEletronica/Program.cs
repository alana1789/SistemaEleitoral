using BLL;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {

        Eleitor eleitor = new Eleitor();
        EleitorBLL eleitorBLL = new EleitorBLL();

        eleitorBLL.Inserir(eleitor);

    }
}