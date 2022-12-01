Build

```docker build -t dockersample:latest .```

Expose internal port 80 to outer 80, mount D:\tmp as /mnt/tmp, use environmnent variable for PATH_TO_FILE and run.

```docker run -p 80:80 -v D:\tmp\:/mnt/tmp --env PATH_TO_FILE=/mnt/tmp/routing_response.json dockersample```

Open browser ```localhost/getfile```