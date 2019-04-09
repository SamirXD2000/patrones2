/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package facadejava;

/**
 *
 * @author FEDERICO DIAZ
 */

import facadejava.Api.fachada.revFachada;
public class FacadeJava {

  public static void main(String[] args) {
		revFachada cliente1 = new revFachada();
		cliente1.buscar("02/07/2018", "08/07/2018", "Lima", "Cancún");

		revFachada cliente2 = new revFachada();
		cliente2.buscar("02/07/2018", "08/07/2018", "Lima", "Quito");
	}
}
