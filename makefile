git:
	git add -A 
	git commit -m $(comm)
	git push -u origin $(repo) 

gitnew:
	git switch -c $(repo)
	git add -A
	git commit -m $(repo)
	git push -u origin $(repo)
