package com;

import javax.xml.ws.Endpoint;

public class Main {
    public static void main(String[] args) {
        Object implementor = new HelloWorld();
        String address = "http://localhost:9000/HelloWorld";
        Endpoint.publish(address, implementor);
    }
}
