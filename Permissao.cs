using System;
namespace AULA15TRYCATCH
{
    public class Permissao
    {
        public bool Permitir { get; set; }


        public void Autorizar(){

            System.Console.WriteLine("Deseja permitir acesso? Digite true ou false");
            try{
                Permitir = Boolean.Parse( Console.ReadLine() );
            }catch(Exception){
                System.Console.WriteLine("Erro na aplicação: dados inválidos");
            }
        }
    }
}