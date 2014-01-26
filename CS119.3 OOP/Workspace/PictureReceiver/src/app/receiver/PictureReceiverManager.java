package app.receiver;


import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.Date;
import java.util.Enumeration;
import java.util.HashMap;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.mortbay.jetty.Request;
import org.mortbay.jetty.Server;
import org.mortbay.jetty.handler.AbstractHandler;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import app.receiver.entities.PictureEntry;
import app.receiver.entities.User;
import app.receiver.repositories.PictureEntryRepository;
import app.receiver.repositories.UserRepository;

import com.fasterxml.jackson.databind.ObjectMapper;
import com.oreilly.servlet.MultipartRequest;

// springs way: do your magic on me
@Component
public class PictureReceiverManager
{

	// JETTY SETTINGS
	
    private Server httpServer;
    private int webServerPort;
    private ObjectMapper mapper = new ObjectMapper();

    public int getWebServerPort()
    {
        return webServerPort;
    }

    public void setWebServerPort(int webServerPort)
    {
        this.webServerPort = webServerPort;
    }
    
    
	// LIFE CYCLE
    
    public void start()
    {
        if (httpServer==null)
        {
            Thread serverRunner = new Thread(new Runnable()
            {
               public void run()
               {
                   System.out.println("Opening Jetty WebServer port: "+webServerPort);
                   httpServer = new Server(webServerPort);
                   httpServer.setHandler(new MyURLHandler());
                   try
                   {
                       httpServer.start();
                   }
                   catch (Exception e)
                   {
                       System.out.println("Error starting Jetty:"+e.getClass().getName());
                   }
                   System.out.println("Opening Jetty WebServer done");
               }
            });
            serverRunner.start();
        }
        
        try
        {
            System.out.println("Creating directory... "+fileDirectory);
            File dir = new File(fileDirectory);
            dir.mkdirs();
        }
        catch(Exception e)
        {
            System.out.println(e);
        }
    }
    
    public void stop()
    {
        // stop web server
        if (httpServer!=null)
        {
            try
            {
                httpServer.stop();
                httpServer.destroy();
            }
            catch(Exception e)
            {
                System.out.println("Error stopping Jetty:"+e.getClass().getName());
            }
            finally
            {
                httpServer = null;
            }
        }
    }

    
    
    // SAVING TO FILESYSTEM
    
    private String fileDirectory = "dump";

    public String getFileDirectory()
    {
        return fileDirectory;
    }

    public void setFileDirectory(String fileDirectory)
    {
        this.fileDirectory = fileDirectory;
    }

    
    // RECEIVER
    private static int MB = 1024 *1024;
    
    
    class MyURLHandler extends AbstractHandler
    {
        public void handle(String target,
                           HttpServletRequest request,
                           HttpServletResponse response,
                           int dispatch) throws IOException, ServletException
        {
            
            System.out.println("=============================================================================");
            
            System.out.println("Target: "+target);            
            System.out.println("URL  : "+request.getRequestURL().toString());
            System.out.println("RequestType  : "+request.getMethod());
            
            
            System.out.println("\nHeaders:");
            for (Enumeration<?> e = request.getHeaderNames(); e.hasMoreElements(); )
            {
                String key = (String) e.nextElement();
                System.out.println(key+" = "+request.getHeader(key));
            }
            
            System.out.println("\nAttributes:");
            for (Enumeration<?> e = request.getAttributeNames(); e.hasMoreElements(); )
            {
                String key = (String) e.nextElement();
                System.out.println(key+" = "+request.getAttribute(key));
            }
            
            System.out.println("=============================================================================");

            
//            if (target.equalsIgnoreCase("/upload"))
//            {
//                try
//                {
//                    DefaultFileRenamePolicy fileRenamePolicy = new DefaultFileRenamePolicy();
//                    
//                    MultipartRequest mrequest = new MultipartRequest(request, fileDirectory, 10*MB, fileRenamePolicy);
//                    
//                    System.out.println("\nParameters:");
//                    Enumeration<?> keys = mrequest.getParameterNames();
//                    for (; keys.hasMoreElements(); )
//                    {
//                        String key = (String) keys.nextElement();
//                        System.out.println(key+" = "+( Arrays.toString(mrequest.getParameterValues(key))));
//                    }
//                    
//
//                    
//                    StringBuffer sb = new StringBuffer();
//                    for (Enumeration<?> names = mrequest.getFileNames(); names.hasMoreElements(); )
//                    {
//                        String s = (String) names.nextElement();
//                        sb.append(mrequest.getFilesystemName(s));
//                        if (names.hasMoreElements())
//                        {
//                            sb.append(", ");
//                        }
//                    }
//                    
//                    System.out.println("Uploaded files: "+sb.toString());
//                    
//                    
//                    try
//                    {
//                        // process message tag and image filenames
//                        processRequest(mrequest);
//                        
//                        // valid request
//                        response.getWriter().println("OK:Your data has been received.");
//                    }
//                    catch(Exception e)
//                    {
//                        e.printStackTrace();
//                        response.getWriter().println("ERROR:Error processing request: "+e.getMessage());                        
//                    }                    
//                }
//                catch(Exception e)
//                {
//                    e.printStackTrace();
//                    
//                    // invalid request
//                    response.getWriter().println("ERROR:Error processing request: "+e.getMessage());
//                }
//            }
            if (target.equalsIgnoreCase("/register")) {
            	System.out.println("register");
            	String jsonString = readStreamAsString(request.getInputStream());
             	System.out.println(jsonString);
            	
            	User user = mapper.readValue(jsonString, User.class);
            	System.out.println(user);
           	          	
				if (userRepository.findByUserName(user.getUserName()) == null) {
					userRepository.save(user);        	
					System.out.println(user);
					
					ServerReply reply = new ServerReply();
					reply.setMessage("REGISTER!!!!");
					jsonString = mapper.writeValueAsString(reply);
					System.out.println(jsonString);
					response.getWriter().println(jsonString);
				}
				else {
					ServerReply reply = new ServerReply();
					reply.setMessage("User name already exists.");
					jsonString = mapper.writeValueAsString(reply);
					System.out.println(jsonString);
					response.getWriter().println(jsonString);
				}
            	
            }
            else if (target.equalsIgnoreCase("/login")) {
            	System.out.println("login");
            	
            	String jsonString = readStreamAsString(request.getInputStream());
            	System.out.println(jsonString);
            	
            	HashMap<String, String> login = mapper.readValue(jsonString, HashMap.class);
            	System.out.println(login);
            	
            	String userName = login.get("username");
            	String password = login.get("password");
            	
            	User user = userRepository.findByUserName(userName);
            	
            	if (user!=null) {
            		if (user.getPassword().equals(password)) {
            			// GOOD
                    	ServerReply reply = new ServerReply();
                    	reply.setMessage("LOGIN!!!!");
                    	
                    	jsonString = mapper.writeValueAsString(reply);
                    	response.getWriter().println(jsonString);
            		}
            		else {
            			// BAD
                    	ServerReply reply = new ServerReply();
                    	reply.setMessage("BAD PASSWORD!!!!");
                    	
                    	jsonString = mapper.writeValueAsString(reply);
                    	response.getWriter().println(jsonString);
            		}
            	}
            	else {
            		// BAD
            		// does not exist
                	ServerReply reply = new ServerReply();
                	reply.setMessage("BAD USER!!!!");
                	
                	jsonString = mapper.writeValueAsString(reply);
                	response.getWriter().println(jsonString);
            	}
            	
            	/**
            	ServerReply reply = new ServerReply();
            	reply.setMessage("LOGIN!!!!");
            	
            	
            	ObjectMapper mapper = new ObjectMapper();
            	jsonString = mapper.writeValueAsString(reply);
            	
            	System.out.println(jsonString);
            	            	
            	response.getWriter().println(jsonString);
            	**/
            }
            else
            {
                // invalid request
                // response.getWriter().println("Unsupported request: "+target);
            }
            
            ((Request) request).setHandled(true);
        }
    }    
    
    private String readStreamAsString(InputStream is) throws IOException
    {
		InputStreamReader isr = new InputStreamReader(is);

		BufferedReader reader = new BufferedReader(isr);
		StringBuilder sb = new StringBuilder();
		String line = null;
		while ((line = reader.readLine()) != null) {
			sb.append(line + "\n");
		}
		
		return sb.toString();
    }

	@Autowired
	// tells Spring "I will create instance of this object and pass to whoever needs"
	private PictureEntryRepository pictureEntryRepository;
	
	@Autowired
	private UserRepository userRepository;
	
    private void processRequest(MultipartRequest mrequest)  throws Exception
    {
    	// get the text data
    	// get the image file paths from the multipart
    	// create a new PictureEntry and save it
    	

    	String fileName = null;
        for (Enumeration<?> names = mrequest.getFileNames(); names.hasMoreElements(); )
        {
            String s = (String) names.nextElement();
            fileName = mrequest.getFilesystemName(s);
            
            // process only 1 file per request, even if more than one come in
            break;
        }
        
        String message = mrequest.getParameter("message");

        
        // create database entry
        
        PictureEntry entry = new PictureEntry();
        
        
        entry.setMessage(message);
        entry.setDateReceived(new Date());
        
        File dirFile = new File(fileDirectory);
        File imageFile = new File(dirFile, fileName);
        entry.setImagePath(imageFile.getAbsolutePath());
        
        pictureEntryRepository.save(entry); // send data into db
        
    }
    
    
    
}
// http://ph.she.yahoo.com/honey-lemon-chicken-023309230.html