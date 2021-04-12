namespace TemplateProject
{
   
    public abstract class CarBase
    {
        
        /// Tworzenie samochodu.
       
        public void Create()
        {
            CreateWheels();
            CreateFrame();
            Unit();
        }

        
        /// Tworzenie kół.
        
        protected abstract void CreateWheels();

        
        /// Tworzenie ramy.
       
        protected abstract void CreateFrame();

        
        /// łączenie kół oraz ramy.
        
        protected abstract void Unit();
    }
}