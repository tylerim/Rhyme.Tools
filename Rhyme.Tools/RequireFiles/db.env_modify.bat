set ProjectRootDir=%1
cd %2
call db.env.bat dev %3
c < %4Y.txt | more
timeout /t -1