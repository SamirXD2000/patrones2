/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package facadejava.Api.fachada;

/**
 *
 * @author FEDERICO DIAZ
 */
import facadejava.Api.AvionApi;
import facadejava.Api.HotelApi;
public class revFachada {
    private AvionApi avionApi;
	private HotelApi hotelApi;	

	public revFachada() {
		avionApi = new AvionApi();
		hotelApi = new HotelApi();
	}

	public void buscar(String fechaIda, String fechaVuelta, String origen, String destino) {
		avionApi.buscarVuelos(fechaIda, fechaVuelta, origen, destino);
		hotelApi.buscarHoteles(fechaIda, fechaVuelta, origen, destino);
	}		
}
