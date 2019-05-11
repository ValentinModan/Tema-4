package com

import javax.jws.WebMethod
import javax.jws.WebService

@WebService
class Hello {

    @WebMethod
    String sayHelloWorldFrom(String from) {
        String result = "Hello, world, from " + from
        System.out.println(result)
        return result
    }
}
