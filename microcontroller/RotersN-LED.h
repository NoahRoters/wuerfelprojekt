// written by others and NOT BY ME (Noah Roters)

class LED 
{
  public:
    LED(int pNr);   // Konstruktor
    ~LED();         // Destruktor
    void ein();
    void aus();
    void setZustand(bool zustand);
    bool getZustand();
  private:
    int pinNr;
};
