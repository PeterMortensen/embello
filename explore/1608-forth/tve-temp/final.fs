\ burn the final application in flash for self-contained use

<<<tvebase>>>
compiletoflash
( main start: ) here dup hex.

include rftemp.fs

: init init unattended main ;
( main end, ram free: ) here hex. compiletoram flashvar-here here - .