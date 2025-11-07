theme = localStorage.getItem("theme")

if (theme === "darkmode")
{
    //darkmode impostata come default
    document.body.classList.add("darkmode")
    localStorage.setItem("theme", "darkmode")
}
else
{
    document.body.classList.remove("darkmode")
    localStorage.setItem("theme", "lightmode")   
}



window.themeUtils = 
{
    switchTheme: function()
    {
        let theme = localStorage.getItem("theme");
        if (theme === "darkmode")
        {
            document.body.classList.remove("darkmode")
            localStorage.setItem("theme", "lightmode") 
        }
        else
        {
            document.body.classList.add("darkmode")
            localStorage.setItem("theme", "darkmode")       
        }
    }
}