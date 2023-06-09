namespace listaed
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)
            Lista lista = new();
            lista.inserirInicio(11);
            lista.inserirInicio(20);
            lista.inserirInicio(5);
            lista.inserirFim(15);
            
            lista.percurso();

            lista.removerInicio();
            lista.removerFim();
            
            lista.percurso();
           
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");


            //2)

            Funcionario lista2 = new Funcionario();
            lista2.inserirInicio("Gustavo Gomez", 15, "999999999", 2200.0);
            lista2.inserirInicio("Raphael Veiga", 23, "777777777", 4500.00);
            lista2.inserirInicio("Endrick", 9, "765756756", 500.00);
            lista2.inserirFim("Piquerez", 22, "788878787", 100.0);
            lista2.inserirFim("Zé Rafael", 8, "438888888", 1800.0);

            lista2.percurso();
            lista2.consultaNome("Raphael Veiga", lista2);

            lista2.removerFim();
            lista2.removerInicio();
            lista2.percurso();

            lista2.impressao();
            
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");



            //3)

            ListaA lista3 = new ListaA();

            lista3.inserirInicio("Professor", 1, 100, "Bruno");
            lista3.inserirInicio("Medico", 1, 100, "João");
            lista3.inserirInicio("Carpinteiro", 1, 150, "Gustavo");
            lista3.inserirInicio("Diretor", 1, 200, "Gabriel");
            lista3.inserirInicio("Policial", 1, 200, "Andre");
            lista3.impressao();
            lista3.consultaNome("Professor", lista3);

            
            


        }
    }
}
