namespace UMLRS{

    class Bonus : iBonus  {
    private int body;

    public void pridejBody(int body)
    {
        this.body += body;
    }

    
     public void resetBody()
    {
        this.body = 0;
    }

    
    public void uberBody(int body)
    {
         this.body -= body;
    }

    public override string ToString()
    {
        return $"Počet bodů: {body}";
    }


}
        
    }