using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/any", Any);

IResult Any([FromBody] Root root)
{
    return Results.Ok();
}

app.Run();

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Account
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Address
{
    public string id { get; set; }
    public string line_1 { get; set; }
    public string line_2 { get; set; }
    public string street { get; set; }
    public string number { get; set; }
    public string complement { get; set; }
    public string zip_code { get; set; }
    public string neighborhood { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string status { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public Metadata metadata { get; set; }
}

public class AntifraudResponse
{
}

public class Customer
{
    public string id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string code { get; set; }
    public string document { get; set; }
    public string type { get; set; }
    public bool delinquent { get; set; }
    public Address address { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public Phones phones { get; set; }
    public Metadata metadata { get; set; }
}

public class Data
{
    public string id { get; set; }
    public string code { get; set; }
    public string gateway_id { get; set; }
    public int amount { get; set; }
    public string status { get; set; }
    public string currency { get; set; }
    public string payment_method { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public bool pending_cancellation { get; set; }
    public Customer customer { get; set; }
    public Order order { get; set; }
    public LastTransaction last_transaction { get; set; }
    public Metadata metadata { get; set; }
}

public class GatewayResponse
{
}

public class HomePhone
{
    public string country_code { get; set; }
    public string number { get; set; }
    public string area_code { get; set; }
}

public class LastTransaction
{
    public string transaction_type { get; set; }
    public string qr_code { get; set; }
    public string qr_code_url { get; set; }
    public DateTime expires_at { get; set; }
    public string id { get; set; }
    public string gateway_id { get; set; }
    public int amount { get; set; }
    public string status { get; set; }
    public bool success { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public GatewayResponse gateway_response { get; set; }
    public AntifraudResponse antifraud_response { get; set; }
    public Metadata metadata { get; set; }
}

public class Metadata
{
    public string moduleVersion { get; set; }
    public string coreVersion { get; set; }
    public string platformVersion { get; set; }
}

public class MobilePhone
{
    public string country_code { get; set; }
    public string number { get; set; }
    public string area_code { get; set; }
}

public class Order
{
    public string id { get; set; }
    public string code { get; set; }
    public int amount { get; set; }
    public bool closed { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public DateTime closed_at { get; set; }
    public string currency { get; set; }
    public string status { get; set; }
    public string customer_id { get; set; }
    public Metadata metadata { get; set; }
}

public class Phones
{
    public HomePhone home_phone { get; set; }
    public MobilePhone mobile_phone { get; set; }
}

public class Root
{
    public string id { get; set; }
    public Account account { get; set; }
    public string type { get; set; }
    public DateTime created_at { get; set; }
    public Data data { get; set; }
}

