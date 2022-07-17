using Newtonsoft.Json;

namespace project1{

  
public class Class1
{


public string Convert<T>(T obj){
    return  JsonConvert.SerializeObject(obj);
}
}
  
}