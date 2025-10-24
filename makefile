.PHONY: git_commit_push

SHELL := /usr/bin/env bash


git_commit:
	git add -A 
	git commit -m "TODO ./docs/dump.md"
	git push -u origin merge

git_commit_push_tmp:
	git add -A 
	git commit -F ./docs/git_commit.md
	git push -u origin tmp

git_clone_dev:
	git clone --branch dev/juan --single-branch git@github.com:Ju3juan/calculadora-cs.git tmp