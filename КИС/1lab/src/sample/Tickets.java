package sample;

public class Tickets {

    public Tickets(int ticketID,int aircrID, int flightID, int price) {
        AircrID = aircrID;
        FlightID = flightID;
        Price = price;
        TicketID = ticketID;
    }

    public int getAircrID() {
        return AircrID;
    }

    public void setAircrID(int aircrID) {
        AircrID = aircrID;
    }

    public int getFlightID() {
        return FlightID;
    }

    public void setFlightID(int flightID) {
        FlightID = flightID;
    }

    public int getPrice() {
        return Price;
    }

    public void setPrice(int price) {
        Price = price;
    }

    public int AircrID;
    public int FlightID;

    public int getTicketID() {
        return TicketID;
    }

    public void setTicketID(int ticketID) {
        TicketID = ticketID;
    }

    public int TicketID;
    public int Price;

    public Tickets()
    {

    }
}
