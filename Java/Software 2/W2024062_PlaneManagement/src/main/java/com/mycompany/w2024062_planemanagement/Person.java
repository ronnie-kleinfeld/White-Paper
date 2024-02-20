package com.mycompany.w2024062_planemanagement;

public class Person {
    private String name;
    private String surname;
    private String email;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public Person(String name, String surname, String email) {
        this.name = name;
        this.surname = surname;
        this.email = email;
    }

    public String toString() {
        String message = String.format("Person name: %1, surname: %2, email: %3", getName(), getSurname(), getEmail());
        ConsoleHelper.println(message);
        return message;
    }
}