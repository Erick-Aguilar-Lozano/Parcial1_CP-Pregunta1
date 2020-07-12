/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mycompany.mavenproject2;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Erick
 */
@WebService(serviceName = "Nombre")
public class Nombre {
    /**
     * Web service que devuelve el nombre y el ci del estudiante
     */
    @WebMethod(operationName = "DevuelveNombre")
    public String DevuelveNombre() {
        String nombre = "Erick Aguilar Lozano" ;
        String ci = "6893912 L.P." ; 
        return nombre + "  " + ci;
    }
    
    
}
