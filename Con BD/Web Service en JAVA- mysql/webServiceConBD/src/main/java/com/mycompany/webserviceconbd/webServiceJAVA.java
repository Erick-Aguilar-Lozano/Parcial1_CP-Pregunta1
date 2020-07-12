/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package com.mycompany.webserviceconbd;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

import java.io.*;
import java.sql.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Erick
 */
@WebService(serviceName="webServiceJAVA")
public class webServiceJAVA {
   
    private String nombre;
 
    /** This is a sample web service operation */
    @WebMethod(operationName="hello")
    public String hello(@WebParam(name="name") String txt) {
        return "Hello "+txt+" !";
    }
    
    @WebMethod
    public String retornaUsuario(){
 
        String conexionBD="jdbc:mysql://127.0.0.1/alumno";
        Connection conexion=null; 
        String con;
        ResultSet rs;
        try{
            // JOptionPane.showMessageDialog(null,"entro");
            Class.forName("com.mysql.jdbc.Driver");//el driver de mysql
            conexion=DriverManager.getConnection(conexionBD, "root","");//conexion a la base de datos
            Statement s = conexion.createStatement();
            con="SELECT * FROM datos" ;
            rs = s.executeQuery (con); {
            while (rs.next()) {
            nombre=rs.getString("nombre");
            //ci=rs.getString("ci");
            break;
            //JOptionPane.showMessageDialog(null, "si");
            }
            }
        }
        catch(Exception e){
        System.out.println("No se ha completado la peticion...");
        }
        return nombre;
    }
}
