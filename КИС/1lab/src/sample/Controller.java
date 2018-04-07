package sample;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import java.text.ParseException;
import javax.swing.*;
import javax.xml.crypto.Data;
import java.sql.*;
import java.util.ArrayList;
import java.text.SimpleDateFormat;

public class Controller {

    private static final String url = "jdbc:mysql://localhost:3306/Airport?useSSL=false";
    private static final String user = "root";
    private static final String password = "6679807n";

    // JDBC variables for opening and managing connection
    private static Connection con;
    private static Statement stmt =null;
    private static ResultSet rs =null;

    @FXML
    public TableView<Aircraft> Tab;
    @FXML
    public TableView<Tickets> Tab1;
    @FXML
    public TableView<Fligths> Tab2;
    @FXML
    public TextField BoardRoom_text;
    @FXML
    public TextField LimitPassenger_text;
    @FXML
    public TextField Make_text;
    @FXML
    public TextField Id_tetx;
    @FXML
    public TextField Type_text;
    @FXML
    public TextField Der_text;
    @FXML
    public TextField Der1_text;
    @FXML
    private ObservableList<Aircraft> usersData = FXCollections.observableArrayList();
    @FXML
    private ObservableList<Tickets> usersData1 = FXCollections.observableArrayList();
    @FXML
    private ObservableList<Fligths> usersData2 = FXCollections.observableArrayList();


    @FXML
    private TableColumn<Aircraft,Integer> BoardRoom;
    @FXML
    private TableColumn<Aircraft,String> Make;
    @FXML
    private TableColumn<Aircraft,Integer> LimitPassenger;
    @FXML
    private TableColumn<Aircraft,String> Type;
    @FXML
    private TableColumn<Aircraft,Integer> AirID;


    @FXML
    private TableColumn<Tickets,Integer> AircrID;
    @FXML
    private TableColumn<Tickets,Integer> FlightID;
    @FXML
    private TableColumn<Tickets,Integer> Price;


    @FXML
    private TableColumn<Fligths,Data> Date ;
    @FXML
    private TableColumn<Fligths,Integer> Time;
    @FXML
    private TableColumn<Fligths,String> Departure;
    @FXML
    private TableColumn<Fligths,String> Destination;
    @FXML
    private TableColumn<Fligths,Time > FlightTime;
    @FXML
    private TableColumn<Fligths,Integer> Distation;
    @FXML
    private TableColumn<Fligths,Integer> FlgthsID;
    @FXML
    private TableColumn<Tickets,Integer> TicketID;





    public void SelectAircraft() throws SQLException {

        AirID.setCellValueFactory(new PropertyValueFactory<Aircraft,Integer>("AirID"));
        BoardRoom.setCellValueFactory(new PropertyValueFactory<Aircraft,Integer>("BoardRoom"));
        LimitPassenger.setCellValueFactory(new PropertyValueFactory<Aircraft,Integer>("LimitPassenger"));
        Type.setCellValueFactory(new PropertyValueFactory<Aircraft,String>("Type"));
        Make.setCellValueFactory(new PropertyValueFactory<Aircraft,String>("Make"));

        try {


            Aircraft ob1 = new Aircraft();

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            rs = stmt.executeQuery("SELECT * from Aircraft");
            usersData.removeAll(usersData);

            while (rs.next()) {
                ob1.AirID=rs.getInt(1);
                ob1.BoardRoom = rs.getInt(2);
                ob1.LimitPassenger = rs.getInt(3);
                ob1.Type = rs.getString(4);
                ob1.Make = rs.getString(5);
                usersData.add(new Aircraft(ob1.AirID,ob1.BoardRoom,ob1.LimitPassenger,ob1.Type,ob1.Make));

                Tab.setItems(usersData);
            }
        }

        finally {
            rs.close();
            stmt.close();

        }

    }
    public void UpdateAircraft() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            PreparedStatement statement = con.prepareStatement(Air.SQL_UPDATE);

            statement.setInt(1,Integer.parseInt(BoardRoom_text.getText()));
            statement.setInt(2,Integer.parseInt(Id_tetx.getText()));
            statement.execute();
        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectAircraft();
        }

    }
    public void DeleteAircraft() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            PreparedStatement statement = con.prepareStatement(Air.SQL_DELETE);
            statement.setInt(1,Integer.parseInt(Id_tetx.getText()));
            statement.execute();
        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectAircraft();
        }

    }
    public void AddAircraft() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();

            PreparedStatement statement = con.prepareStatement(Air.SQL_INSERT);
            statement.setInt(1, Integer.parseInt(BoardRoom_text.getText()));
            statement.setInt(2, Integer.parseInt(LimitPassenger_text.getText()));
            statement.setString(3,Make_text.getText());
            statement.setString(4,Type_text.getText());
            statement.execute();

        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectAircraft();

        }

    }

    public void SelectTickets() throws SQLException {

        AircrID.setCellValueFactory(new PropertyValueFactory<Tickets,Integer>("AircrID"));
        FlightID.setCellValueFactory(new PropertyValueFactory<Tickets,Integer>("FlightID"));
        Price.setCellValueFactory(new PropertyValueFactory<Tickets,Integer>("Price"));
        TicketID.setCellValueFactory(new PropertyValueFactory<Tickets,Integer>("TicketID"));

        try {


            Tickets ob1 = new Tickets();
            usersData1.removeAll(usersData1);
            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            rs = stmt.executeQuery("SELECT * from tickets");

            while (rs.next()) {

                ob1.TicketID=rs.getInt(1);
                ob1.AircrID = rs.getInt(2);
                ob1.FlightID = rs.getInt(3);
                ob1.Price = rs.getInt(4);
                usersData1.add(new Tickets(ob1.TicketID,ob1.AircrID,ob1.FlightID,ob1.Price));
                Tab1.setItems(usersData1);
            }
        }

        finally {
            rs.close();
            stmt.close();
        }

    }
    public void UpdateTickets() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            PreparedStatement statement = con.prepareStatement(Air.SQL_UPDATE1);

            statement.setInt(1,Integer.parseInt(BoardRoom_text.getText()));
            statement.setInt(2,Integer.parseInt(Id_tetx.getText()));
            statement.execute();
        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectTickets();
        }

    }
    public void DeleteTickets() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            PreparedStatement statement = con.prepareStatement(Air.SQL_DELETE1);
            statement.setInt(1,Integer.parseInt(Id_tetx.getText()));
            statement.execute();
        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectTickets();
        }

    }
    public void AddTickets() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();

            PreparedStatement statement = con.prepareStatement(Air.SQL_INSERT1);
            statement.setInt(1, Integer.parseInt(BoardRoom_text.getText()));
            statement.setInt(2, Integer.parseInt(LimitPassenger_text.getText()));
            statement.setInt(3,Integer.parseInt(Make_text.getText()));

            statement.execute();

        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectTickets();
        }

    }

    public void SelectFlights() throws SQLException {

        Date.setCellValueFactory(new PropertyValueFactory<Fligths,Data>("Date_"));
        Time.setCellValueFactory(new PropertyValueFactory<Fligths,Integer>("Time"));
        Departure.setCellValueFactory(new PropertyValueFactory<Fligths,String>("Departure"));
        Destination.setCellValueFactory(new PropertyValueFactory<Fligths,String>("Destination"));
        FlightTime.setCellValueFactory(new PropertyValueFactory<Fligths,Time>("FlightTime"));
        Distation.setCellValueFactory(new PropertyValueFactory<Fligths,Integer>("Distation"));
        FlgthsID.setCellValueFactory(new PropertyValueFactory<Fligths,Integer>("FlgthsID"));
        try {


            Fligths ob1 = new Fligths();
            usersData2.removeAll(usersData2);
            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            rs = stmt.executeQuery("SELECT * from flights");

            while (rs.next()) {

                ob1.FlgthsID = rs.getInt(1);
                ob1.Date_ = rs.getDate(2);
                ob1.Time = rs.getInt(3);
                ob1.Departure = rs.getString(4);
                ob1.Destination = rs.getString(5);
                ob1.Distation = rs.getInt(6);
                ob1.FlightTime = rs.getTime(7);
                usersData2.add(new Fligths(ob1.FlgthsID,ob1.Date_,ob1.Time,ob1.Departure,ob1.Destination,ob1.Distation,ob1.FlightTime));
                Tab2.setItems(usersData2);
            }
        }

        finally {
            rs.close();
            stmt.close();
        }

    }
    public void UpdateFlights() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            PreparedStatement statement = con.prepareStatement(Air.SQL_UPDATE2);

            statement.setInt(1,Integer.parseInt(BoardRoom_text.getText()));
            statement.setInt(2,Integer.parseInt(Id_tetx.getText()));
            statement.execute();
        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectFlights();

        }

    }
    public void DeleteFlights() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            PreparedStatement statement = con.prepareStatement(Air.SQL_DELETE2);
            statement.setInt(1,Integer.parseInt(Id_tetx.getText()));
            statement.execute();
        }
        finally {

            stmt.close();
            usersData.removeAll();
            SelectFlights();
        }

    }
    public void AddFlights() throws SQLException {
        try{

            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();
            SimpleDateFormat formatter = new SimpleDateFormat("yyyy/MM/dd");


            PreparedStatement statement = con.prepareStatement(Air.SQL_INSERT2);
            statement.setDate(1, (java.sql.Date) formatter.parse(BoardRoom_text.getText()));
            statement.setInt(2, Integer.parseInt(LimitPassenger_text.getText()));
            statement.setString(3, Make_text.getText());
            statement.setString(4, Type_text.getText());
            statement.setInt(5,Integer.parseInt(Der_text.getText()));
            statement.setDate(6, (java.sql.Date) formatter.parse(Der1_text.getText()));

            statement.execute();
            SelectTickets();
        } catch (ParseException e) {
            e.printStackTrace();
        } finally {

            stmt.close();
            usersData.removeAll();

        }

    }


    public void View() throws SQLException {
        try
        {
            double Average_Time = 0;
            int SpacesSeat=0;
            int Number_takeoff = 0;
            String Model_aircraft = "";
            String Departure = "";
            String Destination = "";
            int PathCount = 0;


            con = DriverManager.getConnection(url, user, password);
            stmt = con.createStatement();


            rs = stmt.executeQuery("SELECT Avg(Time_) from Tickets INNER JOIN Flights ON Flights.FlightID = Tickets.FlightID INNER JOIN aircraft ON aircraft.AircrID= tickets.AircrID where aircraft.Make='ТУ-154' && flights.Departure='Чугуев' && flights.Destination='Мерефа';");

            while(rs.next()){
                Average_Time = rs.getInt(1);
            }


            JOptionPane.showMessageDialog(null,"Выборка #1: Среднее время полета по маршуту Чугуев-Мерефево Сотовляет: "+Average_Time+"");

            rs = stmt.executeQuery("SELECT Make ,COUNT(*) AS MakeCount  from Tickets INNER JOIN Flights ON Flights.FlightID = Tickets.FlightID  INNER JOIN aircraft ON aircraft.AircrID= tickets.AircrID where flights.Departure='Чугуев' && flights.Destination='Мерефа' GROUP BY Make ORDER BY MakeCount ASC ; ");

            while(rs.next()){
                Number_takeoff=rs.getInt(2);
                Model_aircraft=rs.getString(1);
            }

            JOptionPane.showMessageDialog(null,"Выборка #2: Максимальное количесвто вылетов по маршуту Чугуев-Мерефево Соствляет "+Number_takeoff + " Самолет марки " + Model_aircraft);

            rs = stmt.executeQuery("SELECT   (LimitPassenger - COUNT(*)) AS SpacesSeat  from Tickets INNER JOIN Flights ON Flights.FlightID = Tickets.FlightID  INNER JOIN aircraft ON aircraft.AircrID= tickets.AircrID WHERE Tickets.FlightID = 870 && Date_ = '2000-11-30'; ");

            while(rs.next()){
                SpacesSeat = rs.getInt(1);
            }



            JOptionPane.showMessageDialog(null,"Выборка #3:Наличие свободных мест для рейса №870 , датв 2000-11-31 Состовляет: "+SpacesSeat);

            rs = stmt.executeQuery("SELECT   Departure,Destination ,COUNT(*) AS PathCount from Tickets INNER JOIN Flights ON Flights.FlightID = Tickets.FlightID INNER JOIN aircraft ON aircraft.AircrID= tickets.AircrID WHERE  (100/LimitPassenger * 25) >70  GROUP BY Departure,Destination; ");

            JOptionPane.showMessageDialog(null,"Выборка #4: Популярные маршуты с заполненость более 70%");

            while(rs.next()){

                Departure = rs.getString(1);
                Destination = rs.getString(2);
                PathCount = rs.getInt(3);
                JOptionPane.showMessageDialog(null,"Откуда "+Departure + " Куда " + Destination + " Кол-во вылетов " + PathCount);
            }


        }

        finally
        {
            rs.close();
            stmt.close();
        }

    }
    public void Bacth() throws SQLException {



        int [] updateCounts = null;


        try
        {
            ArrayList <Aircraft> aircrafts = new ArrayList<>();
            PreparedStatement statement = con.prepareStatement("insert into aircraft (BoardRoom ,LimitPassenger,Type_,Make) values (?, ?, ?, ?)");
            for(Aircraft  usersData1: usersData){
                statement.setInt(1,34);
                statement.setInt(2,23);
                statement.setString(3,"Ту-15");
                statement.setString(4,"Чартерный");
                statement.addBatch();
            }
            updateCounts = statement.executeBatch();
        }
        catch (BatchUpdateException e){
            e.printStackTrace();
        }
    }




}

