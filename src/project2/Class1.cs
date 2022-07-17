using Newtonsoft.Json;

namespace project2{
public class Class2
{

public string Convert<T>(T obj){
    return  JsonConvert.SerializeObject(obj);
}
}
}