using ManBoyInterfaceApp.Domain;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  IMannerable[] objects = new IMannerable[3];



            Man man = new Man();
            Boy boy = new Boy();

            AtTheParty(man);
            AtTheParty(boy);

            //AtTheMovies(man);//type mismtach
            AtTheMovies(boy);

            //IMannerable[] objects = new IMannerable[3];
            //objects[0] = man;
            //objects[1] = boy;
            //objects[2] = man;
            

        }
        static void AtTheMovies(IEmotionable obj) {
            Console.WriteLine("At the Movies");
            obj.Cry();
            obj.Laugh();
        }
        static void AtTheParty(IMannerable obj) {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();

            //if (obj is Boy) {
            //    Boy temp = obj as Boy;
            //    temp.Play();
            //}
        
        }
    }
}
