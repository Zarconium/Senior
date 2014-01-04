USE afms;

INSERT INTO audit_group_t VALUES ('1111', 'Internal Audit');
INSERT INTO audit_group_t (audit_group_name) VALUES ('name of audit group here6');
INSERT INTO audit_group_t (audit_group_name) VALUES ('name of audit group here7');
INSERT INTO audit_group_t (audit_group_name) VALUES ('name of audit group here8');
INSERT INTO audit_group_t (audit_group_name) VALUES ('name of audit group here9');
INSERT INTO audit_group_t (audit_group_name) VALUES ('name of audit group here0');

INSERT INTO audit_member_t VALUES ( '0942000', 'Fajardo', 'Francis', 'Yuhico', 'FGYF', 'FGYF@unionbank.com.ph', '1', '1111', 'Internal Audit');
INSERT INTO audit_member_t VALUES ( '1034810', 'Semilla', 'Marione', 'Rivera', 'JMRS', 'MJRS@unionbank.com.ph', '1', '1111', 'Internal Audit');
INSERT INTO audit_member_t VALUES ( '0000010', 'SURNAME', 'FIRSTNAME', 'MIDDLENAME', 'INITIALS', 'EMAIL BLAH HERE', '0', '1112', 'name of audit group here6');
INSERT INTO audit_member_t VALUES ( '0000020', 'SURNAME', 'FIRSTNAME', 'MIDDLENAME', 'INITIALS', 'EMAIL BLAH HERE', '0', '1113', 'name of audit group here7');
INSERT INTO audit_member_t VALUES ( '0000030', 'SURNAME', 'FIRSTNAME', 'MIDDLENAME', 'INITIALS', 'EMAIL BLAH HERE', '0', '1114', 'name of audit group here8');
INSERT INTO audit_member_t VALUES ( '0000040', 'SURNAME', 'FIRSTNAME', 'MIDDLENAME', 'INITIALS', 'EMAIL BLAH HERE', '0', '1115', 'name of audit group here9');
INSERT INTO audit_member_t VALUES ( '0000050', 'SURNAME', 'FIRSTNAME', 'MIDDLENAME', 'INITIALS', 'EMAIL BLAH HERE', '0', '1116', 'name of audit group here0');
UPDATE audit_member_t set email = "user@unionbank.com.ph" WHERE surname = "SURNAME";

INSERT INTO audit_user_t VALUES ( '0942000', 'Admin1', 'password', 'password', 'password', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'ACTIVE', '2012-12-12 08:30:45', '0942000' );
INSERT INTO audit_user_t VALUES ( '1034810', 'Admin2', 'password', 'password', 'password', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'ACTIVE', '2012-12-12 08:30:45', '1034810' );
INSERT INTO audit_user_t VALUES ( '0000100', 'Admin1', 'PASSWORD CURRENT', 'PREVIOUS PASSWORD1', 'PREVIOUS PASSWORD 2', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'STATUS HERE USER', '2012-12-12 08:30:45', '0000010' );
INSERT INTO audit_user_t VALUES ( '0000200', 'Admin2', 'PASSWORD CURRENT', 'PREVIOUS PASSWORD1', 'PREVIOUS PASSWORD 2', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'STATUS HERE USER', '2012-12-12 08:30:45', '0000020' );
INSERT INTO audit_user_t VALUES ( '0000300', 'Admin3', 'PASSWORD CURRENT', 'PREVIOUS PASSWORD1', 'PREVIOUS PASSWORD 2', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'STATUS HERE USER', '2012-12-12 08:30:45', '0000030' );
INSERT INTO audit_user_t VALUES ( '0000400', 'User', 'PASSWORD CURRENT', 'PREVIOUS PASSWORD1', 'PREVIOUS PASSWORD 2', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'STATUS HERE USER', '2012-12-12 08:30:45', '0000040' );
INSERT INTO audit_user_t VALUES ( '0000500', 'Nanay', 'PASSWORD CURRENT', 'PREVIOUS PASSWORD1', 'PREVIOUS PASSWORD 2', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', 'STATUS HERE USER', '2012-12-12 08:30:45', '0000050' );
update audit_user_t  set audit_access_rights = 'Admin3' WHERE audit_user_id = '0000500';


INSERT INTO auditable_unit_t VALUES ( '00000000001', 'name of unit1', 'solll', 'rccc', 'div head name', 'solrcof div head', 'email of div head');
INSERT INTO auditable_unit_t VALUES ( '00000000002', 'name of unit2', 'solll', 'rccc', 'div head name', 'solrcof div head', 'email of div head');
INSERT INTO auditable_unit_t VALUES ( '00000000003', 'name of unit3', 'solll', 'rccc', 'div head name', 'solrcof div head', 'email of div head');
INSERT INTO auditable_unit_t VALUES ( '00000000004', 'name of unit4', 'solll', 'rccc', 'div head name', 'solrcof div head', 'email of div head');
INSERT INTO auditable_unit_t VALUES ( '00000000005', 'name of unit5', 'solll', 'rccc', 'div head name', 'solrcof div head', 'email of div head');



INSERT INTO auditee_officer_t VALUES ( '00000000001', 'surname here', 'first name here', 'middle name here', 'initials', 'emailaddreess@unionbank.com', '00000000001' );
INSERT INTO auditee_officer_t VALUES ( '00000000002', 'surname here', 'first name here', 'middle name here', 'initials', 'emailaddreess@unionbank.com', '00000000002' );
INSERT INTO auditee_officer_t VALUES ( '00000000003', 'surname here', 'first name here', 'middle name here', 'initials', 'emailaddreess@unionbank.com', '00000000003' );
INSERT INTO auditee_officer_t VALUES ( '00000000004', 'surname here', 'first name here', 'middle name here', 'initials', 'emailaddreess@unionbank.com', '00000000004' );
INSERT INTO auditee_officer_t VALUES ( '00000000005', 'surname here', 'first name here', 'middle name here', 'initials', 'emailaddreess@unionbank.com', '00000000005' );


INSERT INTO audit_document_t VALUES ( '00000000001', 'document long name', 'shortname', 'documents purpose' );
INSERT INTO audit_document_t VALUES ( '00000000002', 'document long name', 'shortname', 'documents purpose' );
INSERT INTO audit_document_t VALUES ( '00000000003', 'document long name', 'shortname', 'documents purpose' );
INSERT INTO audit_document_t VALUES ( '00000000004', 'document long name', 'shortname', 'documents purpose' );
INSERT INTO audit_document_t VALUES ( '00000000005', 'document long name', 'shortname', 'documents purpose' );


INSERT INTO engagement_t VALUES ('IA01012012-FF', 'Sample Engagement Francis ', '2012-12-12 08:30:45', '22', '00000000001', '1111', 'Internal Audit', '5days');
INSERT INTO engagement_t VALUES ('IA01012012-JS', 'Sample Engagement Jhaayr ', '2012-12-12 08:30:45', '10', '00000000001', '1111', 'Internal Audit', '12 days');
INSERT INTO engagement_t VALUES ('IA01012012-1', 'name of engagement1', '2012-12-12 08:30:45', '1', '00000000001', '1112', 'name of audit group here6', '10 days');
INSERT INTO engagement_t VALUES ('IA01012012-2', 'name of engagement2', '2012-12-12 08:30:45', '1', '00000000002', '1113', 'name of audit group here7', '10 days');
INSERT INTO engagement_t VALUES ('IA01012012-3', 'name of engagement3', '2012-12-12 08:30:45', '1', '00000000003', '1114', 'name of audit group here8', '10 days');
INSERT INTO engagement_t VALUES ('IA01012012-4', 'name of engagement4', '2012-12-12 08:30:45', '1', '00000000004', '1115', 'name of audit group here9', '10 days');
INSERT INTO engagement_t VALUES ('IA01012012-5', 'name of engagement5', '2012-12-12 08:30:45', '1', '00000000005', '1116', 'name of audit group here0', '10 days');


INSERT INTO documentation_t VALUES ('00000000001', 'ATTACHMENT HERE', 'APPROVER 1', 'APPROVER2' , 'IA01012012-1', '00000000001');
INSERT INTO documentation_t VALUES ('00000000002', 'ATTACHMENT HERE', 'APPROVER 1', 'APPROVER2' , 'IA01012012-2', '00000000002');
INSERT INTO documentation_t VALUES ('00000000003', 'ATTACHMENT HERE', 'APPROVER 1', 'APPROVER2' , 'IA01012012-3', '00000000003');
INSERT INTO documentation_t VALUES ('00000000004', 'ATTACHMENT HERE', 'APPROVER 1', 'APPROVER2' , 'IA01012012-4', '00000000004');
INSERT INTO documentation_t VALUES ('00000000005', 'ATTACHMENT HERE', 'APPROVER 1', 'APPROVER2' , 'IA01012012-5', '00000000005');
INSERT INTO documentation_t VALUES ('00000000006', 'ATTACHMENT FRANCIS', 'APPROVER 1', 'APPROVER2' , 'IA01012012-FF', '00000000001');
INSERT INTO documentation_t VALUES ('00000000007', 'ATTACHMENT JHAAYR', 'APPROVER 1', 'APPROVER2' , 'IA01012012-JS', '00000000001');



INSERT INTO officer_involved_t VALUES ('IA01012012-1', '00000000001');
INSERT INTO officer_involved_t VALUES ('IA01012012-2', '00000000002');
INSERT INTO officer_involved_t VALUES ('IA01012012-3', '00000000003');
INSERT INTO officer_involved_t VALUES ('IA01012012-4', '00000000004');
INSERT INTO officer_involved_t VALUES ('IA01012012-5', '00000000005');
INSERT INTO officer_involved_t VALUES ('IA01012012-FF', '00000000005');
INSERT INTO officer_involved_t VALUES ('IA01012012-JS', '00000000005');




INSERT INTO audit_member_involved_t VALUES ('IA01012012-1', '0000010');
INSERT INTO audit_member_involved_t VALUES ('IA01012012-2', '0000020');
INSERT INTO audit_member_involved_t VALUES ('IA01012012-3', '0000030');
INSERT INTO audit_member_involved_t VALUES ('IA01012012-4', '0000040');
INSERT INTO audit_member_involved_t VALUES ('IA01012012-5', '0000050');
INSERT INTO audit_member_involved_t VALUES ('IA01012012-FF', '0942000');
INSERT INTO audit_member_involved_t VALUES ('IA01012012-JS', '1034810');



INSERT INTO audit_area_t VALUES ('00000000001', 'AREA NAME HERE', 'DESCRIPTION BLAH BLAH');
INSERT INTO audit_area_t VALUES ('00000000002', 'AREA NAME HERE', 'DESCRIPTION BLAH BLAH');
INSERT INTO audit_area_t VALUES ('00000000003', 'AREA NAME HERE', 'DESCRIPTION BLAH BLAH');
INSERT INTO audit_area_t VALUES ('00000000004', 'AREA NAME HERE', 'DESCRIPTION BLAH BLAH');
INSERT INTO audit_area_t VALUES ('00000000005', 'AREA NAME HERE', 'DESCRIPTION BLAH BLAH');
update audit_area_t set audit_area_description = 'AREA DESCIPTION';



INSERT INTO audit_finding_t VALUES ('0000000001', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-5', '00000000001');
INSERT INTO audit_finding_t VALUES ('0000000002', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-4', '00000000002');
INSERT INTO audit_finding_t VALUES ('0000000003', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-3', '00000000003');
INSERT INTO audit_finding_t VALUES ('0000000004', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-2', '00000000004');
INSERT INTO audit_finding_t VALUES ('0000000005', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-1', '00000000005');
INSERT INTO audit_finding_t VALUES ('0000000006', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-FF', '00000000001');
INSERT INTO audit_finding_t VALUES ('0000000007', 'FINDINGS TITLE HERE', 'LOW', 'MEDIUM', '2012-12-12 08:30:45', 'AUDIT AREA HERE', 'HIGH', 'NATURE OF FINDING', 'RISKIMPLICAATION', 'POLICY STANDARDS', 'RECOMMENDATION', 'DESCRIPTION OF PLAN', 'UNIT RESPONSIBLE', 'REMARKS', 'BALANCE LEFT', 'ATTACHED FILE', 'IA01012012-JS', '00000000002');
UPDATE audit_finding_t SET outstanding_balance = 'BALANCE LEFT';



INSERT INTO auditee_t (employee_name, position, unit_assignment, email, phone_number, afs_ref_no) VALUES ('EMPLOYEE NAME', 'POSTITION IN COMPANY', 'UNITASSIGNMENT', 'EMAIL HERE', '9313341', '0000000003'); 
INSERT INTO auditee_t (employee_name, position, unit_assignment, email, phone_number, afs_ref_no) VALUES ('EMPLOYEE NAME', 'POSTITION IN COMPANY', 'UNITASSIGNMENT', 'EMAIL HERE', '9313341', '0000000004'); 
INSERT INTO auditee_t (employee_name, position, unit_assignment, email, phone_number, afs_ref_no) VALUES ('EMPLOYEE NAME', 'POSTITION IN COMPANY', 'UNITASSIGNMENT', 'EMAIL HERE', '9313341', '0000000005'); 
INSERT INTO auditee_t (employee_name, position, unit_assignment, email, phone_number, afs_ref_no) VALUES ('EMPLOYEE NAME', 'POSTITION IN COMPANY', 'UNITASSIGNMENT', 'EMAIL HERE', '9313341', '0000000006'); 
INSERT INTO auditee_t (employee_name, position, unit_assignment, email, phone_number, afs_ref_no) VALUES ('EMPLOYEE NAME', 'POSTITION IN COMPANY', 'UNITASSIGNMENT', 'EMAIL HERE', '9313341', '0000000007'); 


INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '1034810', '1034810', 'MAINTENANCE' , 'USER', 'ADD', 'ADD', '2012-12-12 08:30:45');
INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '0942000', '0942000', 'MAINTENANCE' , 'UNIT', 'EDIT', 'DELETE', '2012-12-12 08:30:45');
INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '0000100', '0000010', 'MAINTENANCE' , 'GROUP', 'EDIT', 'EDIT', '2012-12-12 08:30:45');
INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '0000200', '0000020', 'MAINTENANCE' , 'USER', 'ADD', 'ADD', '2012-12-12 08:30:45');
INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '0000300', '0000030', 'MAINTENANCE' , 'UNIT', 'ADD', 'ADD', '2012-12-12 08:30:45');
INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '0000400', '0000040', 'MAINTENANCE' , 'GROUP', 'EDIT', 'EDIT', '2012-12-12 08:30:45');
INSERT INTO user_history_t (usr_details, usr_time, usr_login, user_history_tcol, audit_user_id, audit_member_id, module, header, subheader, action, logout) VALUES ( 'USER DETAILS', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '2012-12-12 08:30:45', '0000500', '0000050', 'MAINTENANCE' , 'USER', 'EDIT', 'DELETE', '2012-12-12 08:30:45');