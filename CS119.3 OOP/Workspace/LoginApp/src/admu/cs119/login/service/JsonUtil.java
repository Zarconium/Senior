package admu.cs119.login.service;

import java.util.List;

import com.fasterxml.jackson.core.Version;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.module.SimpleModule;

public class JsonUtil {

	private static ObjectMapper serializationMapper;
	private static ObjectMapper deserializationMapper;
	
	static
	{
		serializationMapper = new ObjectMapper();	

		// add the special list serialization for recursive save
		SimpleModule serializationeModule = new SimpleModule("SerializationModule", new Version(1,0,0,null));
		serializationMapper.registerModule(serializationeModule);
		
		
		deserializationMapper = new ObjectMapper();	

		SimpleModule deserializationModule = new SimpleModule("DeserializerModule", new Version(1, 0, 0, null));
	    deserializationMapper.registerModule(deserializationModule);
	}
	
	public static String convertToJson(Object obj) throws Exception
	{
		return serializationMapper.writeValueAsString(obj);
	}
	
	public static Object fromJsonToObject(String jsonString, Class c) throws Exception
	{
//		ObjectMapper mapper = new ObjectMapper();	
//		Object s = mapper.readValue(jsonString, c);
//		return s;
		
		return fromReturnJsonToObject(jsonString, c);
	}

	
	public static Object fromReturnJsonToObject(String jsonString, Class c) throws Exception
	{		
		Object s = deserializationMapper.readValue(jsonString, c);

		// this is not good
		// s = AttributesFixer.scanForLists(s);
		
		return s;
	}

	
	public static <T> List<T> toList(String jsonString, TypeReference<List<T>> typeRef)
	{
		try
		{
			List<T> stuff = deserializationMapper.readValue(jsonString, typeRef);
			return stuff;
		}
		catch (Exception e) 
		{
			throw new RuntimeException(e);
			// TODO: handle exception
		}
	}	
}
