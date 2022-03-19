//parametreli
function MyFuncWithParams(message) {
    alert(message)
}

//parametresiz
function MyFunc() {
    alert('hello');
}



//call dotnet code from javascript


function CallDotnetMethod() {
  
    DotNet.invokeMethodAsync("MauiEgitim", "DotnetMethod");
}

function CallDotnetMethodWithParameter(dotNetHelper) {

    dotNetHelper.invokeMethodAsync("DotnetMethodWithParams", "Hello World");
  //  dotNetHelper.dispose()
}
