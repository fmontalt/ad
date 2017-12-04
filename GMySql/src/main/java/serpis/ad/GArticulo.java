package serpis.ad;

import java.util.Scanner;

public class GArticulo {
	

	public static void main(String[] args) {
		int intento = -1;
		Scanner sc = new Scanner(System.in);
		
		while (intento != 0){
			System.out.println("Menu para la tabla Articulo");
			System.out.println("¿Que quieres hacer?");
			System.out.println("0- Salir");
			System.out.println("1- Nuevo");
			System.out.println("2- Editar");
			System.out.println("3- Eliminar");
			System.out.println("4- Consultar");
			System.out.println("5- Listar");
			
			intento = sc.nextInt();
			
			switch (intento) {
			case 1:
				System.out.println("");
				System.out.println("Vamos a crear un nuevo Articulo:");
				ArticuloUi.NuevoArt();
				break;
			case 2:
				System.out.println("");
				System.out.println("Vamos a editar un Articulo:");
				break;
			case 3:
				System.out.println("");
				System.out.println("Vamos a eliminar un Articulo:");
				break;
			case 4:
				System.out.println("");
				System.out.println("Vamos a consultar un Articulo:");
				break;
			case 5:
				System.out.println("");
				System.out.println("Vamos a listar la tabla Articulo:");
				break;
			default:
				System.out.println("");
				System.out.println("¡¡Adios!!");
				intento = 0;
				break;
			}
			
		}
		
		sc.close();

	}

}
