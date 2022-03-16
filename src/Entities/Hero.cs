namespace Jogo_de_RPG.src.Entities
{
 
     public abstract class Hero 
     {
        
        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level= Level;
            this.HeroType= HeroType;
        }

            public Hero(){

        }

        public string Name;

         public int Level;

         public string HeroType;

         public override string ToString(){
             return this.Name + " " + this.Level + " " + this.HeroType;

        }

         public virtual string Attack(){
             return this.Name + " Atacou com a sua espada";
        
         }

              public virtual string Ninja(){
             return this.Name + " Golpeou o Biggs com a sua espada";
         }
     
           public virtual string Black(){
             return this.Name + " O mestre dos magos";


  
      }
 
    }
}