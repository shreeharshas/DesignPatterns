public sealed class Singleton{
  private static Singleton instance;    //create a static variable to hold data gobal to the class
  private Singleton(){}                 //make the constructor private to avoid instance creation
  
  public Singleton Instance{            //public instance of the static variable
      get{                              //getter alone is enough, no setter required - to avoid updates
          if(instance!=null){           
            return instance;            //return instance if already instanciated
          }
          else{
            instance = new Singleton(); //if not created, create the instance and then return it
            return instance;
          }
      }
  }
}
