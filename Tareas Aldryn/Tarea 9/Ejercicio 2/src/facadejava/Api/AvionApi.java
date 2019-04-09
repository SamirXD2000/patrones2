/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package facadejava.Api;

/**
 *
 * @author FEDERICO DIAZ
 */
public class AvionApi {
    public void buscarVuelos(String fechaIda, String fechaVuelta, String origen, String destino) {
		System.out.println("==============================");
		System.out.println("Vuelos encontrados para " + destino + " desde " + origen);
		System.out.println("Fecha IDA: " + fechaIda + " Fecha Vuelta " + fechaVuelta);
		System.out.println("==============================");
	}
}
