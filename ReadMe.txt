This respitory is for mock Chameleon Trucking company identification flagging service and sofware.

The intention for this project is to track known or suspected chameleon trucking companies in the state of indiana.

We did this by tracking a few simple things the date a previous buisness closed due to citations and other code violations and how fast a new trucking companie opened after under the same owner.
if it was within 2 to 3 weeks with the same owner then it would be flagged imidetly as a Chameleon company.
if it was within 2 to 3 weeks with a different owner it would be flagged as a suspected Chameleon company.
  if goes on for more then a 3 months with no new citations then it would be released from the suspected companies.

We gathered the trucking comanies with a selenium server constiantly pulling any new records from the website (while this was not efficent it was a required part of the project) and there lat:long using googles geolocation API and the ripping apart the json and sending it to the database.
