package sample;

import java.sql.Time;
import java.util.Date;

public class Fligths {
    public Date getDate_() {
        return Date_;
    }

    public void setDate_(Date date_) {
        Date_ = date_;
    }

    public int getTime() {
        return Time;
    }

    public void setTime(int time) {
        Time = time;
    }

    public String getDeparture() {
        return Departure;
    }

    public void setDeparture(String departure) {
        Departure = departure;
    }

    public String getDestination() {
        return Destination;
    }

    public void setDestination(String destination) {
        Destination = destination;
    }

    public int getDistation() {
        return Distation;
    }

    public void setDistation(int distation) {
        Distation = distation;
    }

    public java.sql.Time getFlightTime() {
        return FlightTime;
    }

    public void setFlightTime(java.sql.Time flightTime) {
        FlightTime = flightTime;
    }

    public Date Date_;
    public int Time;

    public int getFlgthsID() {
        return FlgthsID;
    }

    public void setFlgthsID(int flgthsID) {
        FlgthsID = flgthsID;
    }

    public int FlgthsID;
    public String Departure;
    public String Destination;
    public int Distation;
    public java.sql.Time FlightTime;

    public Fligths(int flgthsID, Date date_, int time, String departure, String destination, int distation, java.sql.Time flightTime) {
        Date_ = date_;
        FlgthsID=flgthsID;
        Time = time;
        Departure = departure;
        Destination = destination;
        Distation = distation;
        FlightTime = flightTime;
    }
    public Fligths(){

    }
}
