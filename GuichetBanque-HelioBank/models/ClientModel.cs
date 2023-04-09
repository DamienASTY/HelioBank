using GuichetBanque_HelioBank.kernel;

namespace GuichetBanque_HelioBank.models;

public class ClientModel: Factory
{
    private string _first_name;
    private string _last_name;
    private string _email;
    private int _pin;

    public void getClient()
    {
        
    }
    
    public bool createClient()
    {
        return false;
    }
    
    public bool updateClient()
    {
        return false;
    }
    
    public bool deleteClient()
    {
        return false;
    }
}