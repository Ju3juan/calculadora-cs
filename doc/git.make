make git comm="" branch="main"

make git comm="main(template); add(README.md, makefile, DONE.md, .gitattributes, src, doc, assets); update(calc.cs); root(main);" branch="main"

fn git(comm, repo) 
{
    @info 
    {
        git add -A 
        git commit -m $(comm)
        git push -u origin $(repo) 


        git add -A 
        git commit -m "commit"
        git push -u origin main
    }

    @example 
    {

make git comm="main(template); add(readme.md, makefile, done.md, .gitattributes, src, doc, assets); update(calc.cs); root(main);" branch="main"

    }
}

