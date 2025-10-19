git_push:
	git add -A 
	git commit -m "update(template)"
	git push -u origin tmp 

git_clone_dev:
	git clone --branch dev/juan --single-branch git@github.com:Ju3juan/calculadora-cs.git tmp