package com;

import javax.jws.WebMethod;
import javax.jws.WebService;

@WebService
public class HelloWorld {

    @WebMethod
    public String sayHelloWorldFrom(String from) {
        Hello hello = new Hello();
        return hello.sayHelloWorldFrom(from);
    }
}
