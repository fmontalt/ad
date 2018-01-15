package serpis.ad;

import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class Categoria {
	@Id
	private long id;
	private String nombre;
	
	@Override
	public String toString(){
		return String.format("[%s]%s",id,nombre);
	}

	public void setNombre(String string) {
		this.nombre = nombre;
		
	}
}
