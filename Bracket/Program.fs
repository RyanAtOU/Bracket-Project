open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

[<EntryPoint>]
let main args =
    let builder = WebApplication.CreateBuilder(args)
    let app = builder.Build()

    app.UseDefaultFiles() |> ignore
    app.UseStaticFiles() |> ignore

    app.MapGet("/", (fun (ctx: HttpContext) ->
        ctx.Response.Redirect("/Bracket.html")
        Task.CompletedTask)) |> ignore

    app.Run()

    0
