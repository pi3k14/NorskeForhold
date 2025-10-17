.SILENT :

.PHONY : dummy feature release hotfix


dummy : 
	echo "Select a target [feature|release|hotfix]"

feature :
	scripts/create_feature.sh

release :
	scripts/create_release.sh

hotfix :
	scripts/create_hotfix.sh