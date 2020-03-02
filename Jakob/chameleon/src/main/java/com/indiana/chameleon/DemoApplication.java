package com.indiana.chameleon;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import java.util.*;
import org.springframework.web.bind.annotation.*;
import java.sql.*;

@RestController
@SpringBootApplication
public class DemoApplication {

	public static void main(String[] args) {
		SpringApplication.run(DemoApplication.class, args);
	}

	@RequestMapping(value = "/", method = RequestMethod.GET)
	public List<LiquidTable> compareTable() {
		List response = new ArrayList<LiquidTable>();
		List response2 = new ArrayList<TruckingTable>();
		List response3 = new ArrayList<Chameleon>();
		Connection conn;
		Connect database = new Connect();
		String SQL;
		SQL = "select * from LiquidatedCompanys";
		LiquidTable table = new LiquidTable();
		TruckingTable truck = new TruckingTable();
		Chameleon cham = new Chameleon();
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
            conn = DriverManager.getConnection(database.connection);
            Statement stmt = conn.createStatement();
			ResultSet records = stmt.executeQuery(SQL);
			while(records.next()){
				table = new LiquidTable();
				table.USDOT = records.getString("USDOT");
				table.LegalName = records.getString("LegalName");
				table.DBAName = records.getString("DBAName");
				table.Address = records.getString("Address");
				table.OOSReason = records.getString("OOSReason");
				table.OOSDate = records.getString("OOSDate");
				table.Status = records.getString("Status");
				table.GeoLocation = records.getString("GeoLocation");
				table.adminID = records.getString("addminID");
				response.add(table);
			}
			SQL = "select * from TruckingCompanies";
			ResultSet records2 = stmt.executeQuery(SQL);
			while(records.next()){
				truck = new TruckingTable();
				truck.USDOT = records2.getString("USDOT");
				truck.LegalName = records2.getString("LegalName");
				truck.DBAName = records2.getString("DBAName");
				truck.MCS150_Date = records2.getString("MCS150_Date");
				truck.PHY_STREET_ = records2.getString("PHY_STREET_");
				truck.PHY_CITY_ = records2.getString("PHY_CITY_");
				truck.PHY_STATE_ = records2.getString("PHY_STATE_");
				truck.PHY_ZIP_ = records2.getString("PHY_ZIP_");
				truck.GeoLocation = records2.getString("GeoLocation");
				truck.Address = truck.PHY_STREET_ + " " + truck.PHY_CITY_ + ", " + truck.PHY_STATE_ + " " + truck.PHY_ZIP_;
				response2.add(truck);
				for(int x = 0; x < response.size(); x++){
					cham = new Chameleon();
					if ((truck.Address.equals(((LiquidTable) response.get(x)).Address))
							&& (truck.GeoLocation.equals(((LiquidTable) response.get(x)).GeoLocation))) {
						cham.USDOT = truck.USDOT;
						cham.adminID= "3/2/2020";
						response3.add(cham);
					}
				}
			}
		} 
		catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return response3;
	}

}
